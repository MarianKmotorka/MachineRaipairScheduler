using AutoMapper;
using FluentValidation;
using MachineRepairScheduler.WebApi.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Users
{
    public class Login
    {
        public class Command : IRequest<CommandResponse>
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, CommandResponse>
        {
            private IIdentityService _IdentityService;
            private IMapper _mapper;

            public CommandHandler(IIdentityService identityService, IMapper mapper)
            {
                _IdentityService = identityService;
                _mapper = mapper;
            }

            public async Task<CommandResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var result = await _IdentityService.LoginAsync(request.Email, request.Password);
                return _mapper.Map<CommandResponse>(result);
            }
        }

        public class CommandResponse
        {
            public string Token { get; set; }
            public bool Success { get; set; }
            public string UserRole { get; set; }
            public IEnumerable<string> Errors { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Email).EmailAddress().WithMessage("Email has invalid format.");
                RuleFor(x => x.Password).Must(x => x.Length > 7).Must(x => x.Any(char.IsDigit));
            }
        }
    }
}
