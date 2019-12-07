using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Domain;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Entities;
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
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        private JwtSettings _jwtSettings;
        private DataContext _context;

        public IdentityService(UserManager<ApplicationUser> userManager, JwtSettings jwtSettings,
               RoleManager<ApplicationRole> roleManager, DataContext context)

        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtSettings = jwtSettings;
            _context = context;
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

        public async Task<OperationResult> RegisterAsync(RegisterModel model)
        {
            var existingUser = await _userManager.FindByEmailAsync(model.EmailAddress);

            if (existingUser != null)
                return new OperationResult { Errors = new[] { "User with this email address already exists." } };

            var newUser = new ApplicationUser
            {
                Email = model.EmailAddress,
                UserName = model.EmailAddress,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthCertificateNumber = model.BirthCertificateNumber
            };

            var identityResult = await _userManager.CreateAsync(newUser, model.Password);

            if (!identityResult.Succeeded)
                return new OperationResult { Errors = identityResult.Errors.Select(x => x.Description) };

            identityResult = await _userManager.AddToRoleAsync(newUser, model.Role.ToString());

            if (!identityResult.Succeeded)
                return new OperationResult { Errors = identityResult.Errors.Select(x => x.Description) };

            var createdUser = await _userManager.FindByEmailAsync(model.EmailAddress);

            switch (model.Role)
            {
                case Role.Employee:
                    _context.Employees.Add(new Employee { IdentityUser = createdUser });
                    break;
                case Role.Technician:
                    _context.Technicians.Add(new Technician { IdentityUser = createdUser });
                    break;
                case Role.PlanningManager:
                    _context.PlanningManagers.Add(new PlanningManager { IdentityUser = createdUser });
                    break;
                default:
                    throw new ArgumentException($"{model.Role} role registration not supported.");
            }

            await _context.SaveChangesAsync();

            return new OperationResult { Success = true };
        }

        private async Task<AuthenticationResult> GenerateAuthenticationResultForUserAsync(ApplicationUser user)
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
        private async Task<List<Claim>> GetRoleClaims(ApplicationUser user)
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
