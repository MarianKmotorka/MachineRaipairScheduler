using AutoMapper;
using FluentValidation;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Services;
using MediatR;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Users
{
    public class Register
    {
        public class Command : IRequest<CommandResponse>
        {
            public string EmailAddress { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string BirthCertificateNumber { get; set; }
            public RegisterableRole Role { get; set; }

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
                var result = await _identityService.RegisterAsync(_mapper.Map<RegisterModel>(request));
                return _mapper.Map<CommandResponse>(result);
            }
        }

        public class CommandResponse
        {
            public bool Success { get; set; }
            public IEnumerable<string> Errors { get; set; }
        } 

        public enum RegisterableRole
        {
            Employee = 1,
            Technician = 2,
            PlanningManager = 3
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Invalid email address.");
                RuleFor(x => x.Role).Must(x => x > 0 && (int)x < 4).WithMessage("Invalid role.");
                RuleFor(x => x.FirstName).Must(x => x.Length > 1 && x.Length < 30).WithMessage("Must have minimum of 2 chars and maximum of 29 chars.");
                RuleFor(x => x.LastName).Must(x => x.Length > 1 && x.Length < 30).WithMessage("Must have minimum of 2 chars and maximum of 29 chars.");
                RuleFor(x => x.BirthCertificateNumber).Must(x => x.Length > 0).WithMessage("Is Required.");
                RuleFor(x => x.PhoneNumber).Must(IsEmptyOrPhoneNumber).WithMessage("Invalid phone number.");

            }

            private bool IsEmptyOrPhoneNumber(string value)
            {
                if (string.IsNullOrEmpty(value)) return true;
                return Regex.IsMatch(value, "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$");
            }
        }
    }
}
