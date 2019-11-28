using Microsoft.AspNetCore.Identity;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationRole Role { get; set; }
    }
}
