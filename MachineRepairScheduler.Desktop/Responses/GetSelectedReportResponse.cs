using MachineRepairScheduler.Desktop.Models;
using System;
using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Responses
{
    public class GetSelectedReportResponse
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public MachineReportInfo Machine { get; set; }
        public string MachineName { get; set; }
        public MadeBy MadeBy { get; set; }
        public string MadeByEmail { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? FixedDate { get; set; }
        public DateTime? PlannedFixDate { get; set; }
        public bool Fixed { get; set; }
        public IEnumerable<Technician> Technicians { get; set; }
        public int TechniciansCount { get; set; }
    }
}
