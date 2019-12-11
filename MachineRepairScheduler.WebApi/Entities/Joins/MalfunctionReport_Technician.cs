namespace MachineRepairScheduler.WebApi.Entities.Joins
{
    public class MalfunctionReport_Technician
    {
        public string TechnicianId { get; set; }
        public Technician Technician { get; set; }
        public string MalfunctionReportId { get; set; }
        public MalfunctionReport MalfunctionReport { get; set; }
    }
}
