using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Users
{
    public class DeleteUser
    {
        public class Query : IRequest<GenericResponse>
        {
            public string UserId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, GenericResponse>
        {
            private UserManager<ApplicationUser> _userManager;

            public QueryHandler(UserManager<ApplicationUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<GenericResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByIdAsync(request.UserId);
                var result = await _userManager.DeleteAsync(user);

                return new GenericResponse
                {
                    Success = result.Succeeded,
                    Errors = result.Errors?.Select(x => x.Description)
                };
            }
        }
    }
}
