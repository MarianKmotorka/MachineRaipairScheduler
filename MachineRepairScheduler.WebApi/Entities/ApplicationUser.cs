using Microsoft.AspNetCore.Identity;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthCertificateNumber { get; set; }
    }
}
