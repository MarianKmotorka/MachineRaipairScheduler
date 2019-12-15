using Microsoft.AspNetCore.Http;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace MachineRepairScheduler.WebApi.Services
{
    public class RequestTokenInfo : IRequestTokenInfo
    {
        public string UserId { get; }
        public string JwtTokenId { get; }
        public string UserRole { get; }
        public string Email { get; set; }

        public RequestTokenInfo(HttpContext context)
        {
            if (context?.User is null) throw new ArgumentException("HttpContext is null");

            UserId = context.User.Claims.Single(x => x.Type == "id").Value;
            JwtTokenId = context.User.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
            UserRole = context.User.Claims.Single(x => x.Type == ClaimTypes.Role).Value;
            Email = context.User.Claims.Single(x => x.Type == ClaimTypes.Email).Value;
        }
    }
}
