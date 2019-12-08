using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Users
{
    public class ChangePassword
    {
        public class Command : IRequest<GenericResponse>
        {
            [JsonIgnore]
            public string UserId { get; set; }
            public string CurrentPassword { get; set; }
            public string NewPassword { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, GenericResponse>
        {
            private UserManager<ApplicationUser> _userManager;

            public CommandHandler(UserManager<ApplicationUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<GenericResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByIdAsync(request.UserId);
                var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

                return new GenericResponse
                {
                    Success = result.Succeeded,
                    Errors = result.Errors.Any() ? result.Errors.Select(x => x.Description) : new[] { "" }
                };
            }
        }
    }
}
