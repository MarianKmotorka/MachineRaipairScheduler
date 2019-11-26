using AutoMapper;
using FluentValidation;
using MachineRepairScheduler.WebApi.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1
{
    public class Register
    {
        public class Command : IRequest<CommandResponse>
        {
            public string EmailAddress { get; set; }
            public string Password { get; set; }
            public Role Role { get; set; }

        }

        public class CommandHandler : IRequestHandler<Command, CommandResponse>
        {
            private IIdentityService _identityService;
            private IMapper _mapper;

            public CommandHandler(IIdentityService identityService, IMapper mapper)
            {
                _identityService = identityService;
                _mapper = mapper;
            }

            public async Task<CommandResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var result = await _identityService.RegisterAsync(request.EmailAddress, request.Password, request.Role.ToString());
                return _mapper.Map<CommandResponse>(result);
            }
        }

        public class CommandResponse
        {
            public bool Success { get; set; }
            public IEnumerable<string> Errors { get; set; }
        } 

        public enum Role
        {
            Employee,
            Technician,
            PlanningManager
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Invalid email address.");
            }
        }
    }
}
