using AutoMapper;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1
{
    public class GetUser
    {
        public class Query : IRequest<UserDto>
        {
            public string UserId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, UserDto>
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

            public async Task<UserDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == request.UserId);

                if (user is null) return null;

                var userDto = _mapper.Map<UserDto>(user);

                userDto.Role = (await _userManager.GetRolesAsync(user)).Single();

                return userDto;
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
    }
}
