namespace MachineRepairScheduler.Desktop.Models
{
    public class GetSelectedUserResponse
    {
        public string userId { get; set; }
        public string emailAddress { get; set; }
        public Role role { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthCertificateNumber { get; set; }
        public string phoneNumber { get; set; }
    }
}
