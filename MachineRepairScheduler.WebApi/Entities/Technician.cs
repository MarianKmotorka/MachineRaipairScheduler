using MachineRepairScheduler.WebApi.Entities.Joins;
using System.Collections.Generic;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class Technician
    {
        public string Id { get; set; }
        public ICollection<MalfunctionReport_Technician> AssignedReports { get; set; }
        public ApplicationUser IdentityUser 
        {
            get => _identityUser;
            set
            {
                if(value != null) Id = value.Id;
                _identityUser = value;
            }
        }

        private ApplicationUser _identityUser;
    }
}
