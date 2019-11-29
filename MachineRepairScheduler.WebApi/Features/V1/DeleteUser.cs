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
    public class DeleteUser
    {
        public class Query : IRequest<QueryRepsonse>
        {
            public string UserId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, QueryRepsonse>
        {
            private UserManager<ApplicationUser> _userManager;

            public QueryHandler(UserManager<ApplicationUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<QueryRepsonse> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByIdAsync(request.UserId);
                var result = await _userManager.DeleteAsync(user);

                return new QueryRepsonse
                {
                    Success = result.Succeeded,
                    Error = result.Errors.Any() ? result.Errors.First().Description : null
                };
            }
        }

        public class QueryRepsonse
        {
            public bool Success { get; set; }
            public string Error { get; set; }
        }
    }
}
