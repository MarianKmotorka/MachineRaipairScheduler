using System;
using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Models
{
    public class Report
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public MachineReportInfo Machine { get; set; }
        public string MachineName { get; set; }
        public MadeBy MadeBy { get; set; }
        public string MadeByEmail { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? FixDate { get; set; }
        public bool Fixed { get; set; }
        public IEnumerable<Technician> Technicians { get; set; }
    }
}
