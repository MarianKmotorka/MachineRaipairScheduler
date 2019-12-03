using AutoMapper;
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

namespace MachineRepairScheduler.WebApi.Features.V1.Users
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
            private IMapper _mapper;

            public QueryHandler(UserManager<ApplicationUser> userManager, DataContext context, IMapper mapper)
            {
                _userManager = userManager;
                _context = context;
                _mapper = mapper;
            }

            public async Task<PagedResponse<UserDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var users = await _context.Users.ToListAsync();

                var userDtos = users.Select(_mapper.Map<UserDto>).ToList();
                
                for (int i = 0; i < userDtos.Count(); i++)
                {
                    userDtos[i].Role = (await _userManager.GetRolesAsync(users[i])).First();
                }

                userDtos = ApplyFilters(userDtos, request.QueryFilter).OrderBy(x => x.EmailAddress).ToList();

                return ApplyPagination(userDtos, request.PaginationQuery);
            }

            private IEnumerable<UserDto> ApplyFilters(IEnumerable<UserDto> users, QueryFilter filter)
            {
                if (!string.IsNullOrEmpty(filter.EmailAddress))
                    users = users.Where(x => x.EmailAddress.Contains(filter.EmailAddress, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(filter.Role))
                    users = users.Where(x => x.Role.Contains(filter.Role, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(filter.FirstName))
                    users = users.Where(x => x.FirstName.Contains(filter.FirstName, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(filter.LastName))
                    users = users.Where(x => x.LastName.Contains(filter.LastName, StringComparison.OrdinalIgnoreCase));

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
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string BirthCertificateNumber { get; set; }
            public string PhoneNumber { get; set; }
        }

        public class QueryFilter
        {
            public string EmailAddress { get; set; }
            public string Role { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
