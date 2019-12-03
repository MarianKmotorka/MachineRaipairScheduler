namespace MachineRepairScheduler.WebApi.Domain.IdentityModels
{
    public static class Roles
    {
        public const string SysAdmin = nameof(SysAdmin);
        public const string Employee = nameof(Employee);
        public const string Technician = nameof(Technician);
        public const string PlanningManager = nameof(PlanningManager);
        public const string AllRoles = nameof(SysAdmin) + "," + nameof(Employee) + "," + nameof(Technician) + "," + nameof(PlanningManager);
    }
}
