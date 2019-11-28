using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1
{
    public class GetAllUsers
    {
        public class Query : IRequest<PagedResponse<UserDto>>
        {
            public PaginationQuery PaginationQuery { get; set; }
            public QueryFilter QueryFilter { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, PagedResponse<UserDto>>
        {
            private UserManager<ApplicationUser> _userManager;
            private DataContext _context;

            public QueryHandler(UserManager<ApplicationUser> userManager, DataContext context)
            {
                _userManager = userManager;
                _context = context;
            }

            public async Task<PagedResponse<UserDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var users = await _context.Users.ToListAsync();

                var userDtos = users.Select(x => new UserDto
                {
                    EmailAddress = x.Email,
                    UserId = x.Id
                }).ToList();
                
                for (int i = 0; i < userDtos.Count(); i++)
                {
                    userDtos[i].Role = (await _userManager.GetRolesAsync(users[i])).First();
                }

                userDtos = ApplyFilters(userDtos, request.QueryFilter).ToList();

                return ApplyPagination(userDtos, request.PaginationQuery);
            }

            private IEnumerable<UserDto> ApplyFilters(IEnumerable<UserDto> users, QueryFilter filter)
            {
                if (!string.IsNullOrEmpty(filter.EmailAddress))
                    users = users.Where(x => x.EmailAddress.Contains(filter.EmailAddress, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(filter.Role))
                    users = users.Where(x => x.Role.Contains(filter.Role, StringComparison.OrdinalIgnoreCase));

                return users;
            }

            private PagedResponse<UserDto> ApplyPagination(IEnumerable<UserDto> users, PaginationQuery paginationQuery)
            {
                var skip = (paginationQuery.PageNumber - 1) * paginationQuery.PageSize;
                return new PagedResponse<UserDto>(users.Skip(skip).Take(paginationQuery.PageSize))
                {
                    PageSize = paginationQuery.PageSize,
                    PageNumber = paginationQuery.PageNumber,
                    Pages = ((int)Math.Ceiling((decimal)users.Count() / paginationQuery.PageSize))
                };
            }
        }

        public class UserDto
        {
            public string UserId { get; set; }
            public string EmailAddress { get; set; }
            public string Role { get; set; }
        }

        public class QueryFilter
        {
            public string EmailAddress { get; set; }
            public string Role { get; set; }
        }
    }
}
