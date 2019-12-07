using System.ComponentModel.DataAnnotations;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class Machine
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public string MachineName { get; set; }
        public string ManufacturerName { get; set; }
        public string YearOfManufacture { get; set; }
        public bool ToBeRemoved { get; set; }
    }
}
