using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1
{
    public class ChangePassword
    {
        public class Command : IRequest<CommandResponse>
        {
            public string UserId { get; set; }
            public string CurrentPassword { get; set; }
            public string NewPassword { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, CommandResponse>
        {
            private UserManager<ApplicationUser> _userManager;

            public CommandHandler(UserManager<ApplicationUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<CommandResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByIdAsync(request.UserId);
                var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

                return new CommandResponse
                {
                    Success = result.Succeeded,
                    Errors = result.Errors.Any() ? result.Errors.Select(x => x.Description) : new[] { "" }
                };
            }
        }

        public class CommandResponse
        {
            public bool Success { get; set; }
            public IEnumerable<string> Errors { get; set; }
        }
    }
}
