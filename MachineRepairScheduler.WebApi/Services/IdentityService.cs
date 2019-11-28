using MachineRepairScheduler.WebApi.Domain;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Services
{
    public class IdentityService : IIdentityService
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private JwtSettings _jwtSettings;

        public IdentityService(UserManager<IdentityUser> userManager, JwtSettings jwtSettings,
               RoleManager<IdentityRole> roleManager)

        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtSettings = jwtSettings;
        }

        public async Task<AuthenticationResult> LoginAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
                return new AuthenticationResult { Errors = new[] { "User does not exist." } };

            var hasUserValidPassword = await _userManager.CheckPasswordAsync(user, password);

            if (!hasUserValidPassword)
                return new AuthenticationResult { Errors = new[] { "Invalid Password" } };

            var result = await GenerateAuthenticationResultForUserAsync(user);
            result.UserRole = (await _userManager.GetRolesAsync(user)).Single();
            return result;
        }
        public async Task<OperationResult> RegisterAsync(string email, string password, params string[] roles)
        {
            var existingUser = await _userManager.FindByEmailAsync(email);

            if (existingUser != null)
                return new OperationResult { Errors = new[] { "User with this email address already exists." } };

            var newUser = new IdentityUser
            {
                Email = email,
                UserName = email
            };

            var identityResult = await _userManager.CreateAsync(newUser, password);

            if (!identityResult.Succeeded)
                return new OperationResult { Errors = identityResult.Errors.Select(x => x.Description) };

            if (roles.Any())
                foreach (var role in roles)
                {
                    identityResult = await _userManager.AddToRoleAsync(newUser, role);

                    if (!identityResult.Succeeded)
                        return new OperationResult { Errors = identityResult.Errors.Select(x => x.Description) };
                }

            return new OperationResult { Success = true };
        }

        private async Task<AuthenticationResult> GenerateAuthenticationResultForUserAsync(IdentityUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("id", user.Id)
            };

            var userClaims = await _userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);

            var roleClaims = await GetRoleClaims(user);
            claims.AddRange(roleClaims);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(_jwtSettings.TokenLifeTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new AuthenticationResult
            {
                Success = true,
                Token = tokenHandler.WriteToken(token),
            };
        }
        private async Task<List<Claim>> GetRoleClaims(IdentityUser user)
        {
            var claims = new List<Claim>();

            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
                var role = await _roleManager.FindByNameAsync(userRole);
                if (role == null) continue;
                var roleClaims = await _roleManager.GetClaimsAsync(role);

                foreach (var roleClaim in roleClaims)
                {
                    if (claims.Contains(roleClaim))
                        continue;

                    claims.Add(roleClaim);
                }
            }

            return claims;
        }
    }
}
