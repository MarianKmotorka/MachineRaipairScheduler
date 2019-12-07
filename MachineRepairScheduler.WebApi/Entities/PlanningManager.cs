namespace MachineRepairScheduler.WebApi.Entities
{
    public class PlanningManager 
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
        public bool HasChangedRole { get; set; }


        private ApplicationUser _identityUser;
    }
}
