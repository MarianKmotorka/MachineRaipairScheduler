using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Entities.Joins;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MachineRepairScheduler.WebApi.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<PlanningManager> PlanningManagers { get; set; }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<MalfunctionReport> MalfunctionReports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<ApplicationRole>().ToTable("Roles");
            builder.Entity<MalfunctionReport_Technician>().ToTable("MalfunctionReport_Technician");

            builder.Entity<MalfunctionReport_Technician>().HasKey(x => new { x.MalfunctionReportId, x.TechnicianId });
            builder.Entity<MalfunctionReport_Technician>().HasOne(x => x.Technician).WithMany(x => x.AssignedReports).HasForeignKey(x => x.TechnicianId);
            builder.Entity<MalfunctionReport_Technician>().HasOne(x => x.MalfunctionReport).WithMany(x => x.Technicians).HasForeignKey(x => x.MalfunctionReportId);
        }
    }
}
