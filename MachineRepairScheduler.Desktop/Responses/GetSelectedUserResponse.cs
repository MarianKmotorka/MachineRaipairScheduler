using MachineRepairScheduler.Desktop.Models;

namespace MachineRepairScheduler.Desktop.Responses
{
    public class GetSelectedUserResponse
    {
        public string UserId { get; set; }
        public string EmailAddress { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthCertificateNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
