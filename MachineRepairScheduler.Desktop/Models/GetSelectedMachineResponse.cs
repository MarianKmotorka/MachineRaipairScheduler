namespace MachineRepairScheduler.Desktop.Models
{
    public class GetSelectedMachineResponse
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public string MachineName { get; set; }
        public string ManufacturerName { get; set; }
        public string YearOfManufacture { get; set; }
    }
}
