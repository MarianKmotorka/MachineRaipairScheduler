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

    public enum Role
    {
        SysAdmin = 0,
        Employee = 1,
        Technician = 2,
        PlanningManager = 3
    }
}
