using AutoMapper;
using FluentValidation;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1
{
    public class EditUser
    {
        public class Command : IRequest<CommandResponse>
        {
            [JsonIgnore]
            public string UserId { get; set; }
            public string EmailAddress { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
            public string BirthCertificateNumber { get; set; }
            public Role Role { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, CommandResponse>
        {
            private UserManager<ApplicationUser> _userManager;
            private DataContext _context;

            public CommandHandler(UserManager<ApplicationUser> userManager, DataContext context)
            {
                _userManager = userManager;
                _context = context;
            }

            public async Task<CommandResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByIdAsync(request.UserId);

                if (user is null) return new CommandResponse { Errors = new[] { "User doesn't exist" } };

                if (user.Email != request.EmailAddress)
                {
                    var emailToken = await _userManager.GenerateChangeEmailTokenAsync(user, request.EmailAddress);
                    var result = await _userManager.ChangeEmailAsync(user, request.EmailAddress, emailToken);

                    if (!result.Succeeded)
                        return new CommandResponse { Errors = result.Errors.Select(x => x.Description) };
                }

                var userRole = (await _userManager.GetRolesAsync(user)).Single();

                if (userRole != request.Role.ToString())
                {
                    await _userManager.RemoveFromRoleAsync(user, userRole);
                    await _userManager.AddToRoleAsync(user, request.Role.ToString());
                }

                if (!string.IsNullOrEmpty(request.Password))
                {
                    var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var resetResult = await _userManager.ResetPasswordAsync(user, resetToken, request.Password);

                    if (!resetResult.Succeeded)
                        return new CommandResponse { Errors = resetResult.Errors.Select(x => x.Description) };
                }

                user = _context.Users.Single(x => x.Id == request.UserId);

                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.PhoneNumber = request.PhoneNumber;
                user.BirthCertificateNumber = request.BirthCertificateNumber;

                await _context.SaveChangesAsync(cancellationToken);

                return new CommandResponse { Success = true };
            }
        }

        public class CommandResponse
        {
            public bool Success { get; set; }
            public IEnumerable<string> Errors { get; set; }
        }

        public enum Role
        {
            SysAdmin = 0,
            Employee = 1,
            Technician = 2,
            PlanningManager = 3
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Role).Must(x => x > 0 && (int)x <= 4).WithMessage("Invalid role.");
                RuleFor(x => x.FirstName).Must(x => x.Length > 1 && x.Length < 30).WithMessage("Must have minimum of 2 chars and maximum of 29 chars.");
                RuleFor(x => x.LastName).Must(x => x.Length > 1 && x.Length < 30).WithMessage("Must have minimum of 2 chars and maximum of 29 chars.");
                RuleFor(x => x.PhoneNumber).Must(IsEmptyOrPhoneNumber).WithMessage("Invalid phone number.");
                RuleFor(x => x.Password).Must(x => string.IsNullOrEmpty(x) || x.Length > 7).WithMessage("Minimum of 8 chars.");
            }

            private bool IsEmptyOrPhoneNumber(string value)
            {
                if (string.IsNullOrEmpty(value)) return true;
                return Regex.IsMatch(value, "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$");
            }
        }
    }
}
