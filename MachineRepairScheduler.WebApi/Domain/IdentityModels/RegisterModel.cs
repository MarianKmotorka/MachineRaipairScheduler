using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MachineRepairScheduler.WebApi.Features.V1.Register;

namespace MachineRepairScheduler.WebApi.Domain.IdentityModels
{
    public class RegisterModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthCertificateNumber { get; set; }
        public Role Role { get; set; }
    }
}
