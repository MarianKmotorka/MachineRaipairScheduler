using System.Collections.Generic;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class Employee
    {
        public string Id { get; set; }
        public ICollection<MalfunctionReport> ReportsMade { get; set; }
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
