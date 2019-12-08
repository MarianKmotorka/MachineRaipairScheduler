using MachineRepairScheduler.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using static MachineRepairScheduler.WebApi.Entities.MalfunctionReport;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public partial class GetAllReports
    {
        public class Filter
        {
            public string MachineName { get; set; }
            public bool NotScheduled { get; set; }
            public bool Scheduled { get; set; }
            public bool NotFixed { get; set; }
            public bool Fixed { get; set; }
            public bool Overdue { get; set; }
        }

        private static IQueryable<MalfunctionReport> ApplyFilter(Filter filter, IQueryable<MalfunctionReport> query)
        {
            if (!string.IsNullOrEmpty(filter.MachineName)) query = query.Where(x => x.Machine.MachineName.Contains(filter.MachineName));
            if (filter.NotScheduled) query = query.Where(x => x.FixDate == null);
            if (filter.Scheduled) query = query.Where(x => x.FixDate != null);
            if (filter.Fixed) query = query.Where(x => x.Fixed);
            if (filter.NotFixed) query = query.Where(x => !x.Fixed);
            if (filter.Overdue) query = query.Where(x => x.FixDate != null && x.FixDate < DateTime.UtcNow && !x.Fixed);

            return query;
        }

        public class ReportDto
        {
            public string Id { get; set; }
            public string Message { get; set; }
            public string MachineId { get; set; }
            public string MachineName { get; set; }
            public UserLookup MadeBy { get; set; }
            public PriorityEnum Priority { get; set; }
            public DateTime CreateDate { get; set; }
            public DateTime? FixDate { get; set; }
            public bool Fixed { get; set; }
            public IEnumerable<UserLookup> Technicians { get; set; }
        }

        public class UserLookup
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string EmailAddress { get; set; }
        }
    }
}
