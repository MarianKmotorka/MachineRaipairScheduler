using MachineRepairScheduler.WebApi.Entities.Joins;
using System;
using System.Collections.Generic;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class MalfunctionReport
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public Machine Machine { get; set; }
        public string MachineId { get; set; }
        public Employee MadeBy { get; set; }
        public string MadeById { get; set; }
        public PriorityEnum Priority { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? FixDate { get; set; }
        public bool Fixed { get; set; }
        public ICollection<MalfunctionReport_Technician> Technicians { get; set; }

        public enum PriorityEnum
        {
            Low = 0,
            Medium = 1,
            High = 2
        }
    }
}
