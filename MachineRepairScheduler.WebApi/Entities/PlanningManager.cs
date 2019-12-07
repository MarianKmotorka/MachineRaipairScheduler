using Microsoft.AspNetCore.Identity;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class PlanningManager : ApplicationUser
    {
        public string Id { get; set; }
        public ApplicationUser IdentityUser
        {
            get => _identityUser;
            set
            {
                if (value != null) Id = value.Id;
                _identityUser = value;
            }
        }

        private ApplicationUser _identityUser;
    }
}
