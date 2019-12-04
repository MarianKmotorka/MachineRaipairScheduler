using MachineRepairScheduler.WebApi.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MachineRepairScheduler.WebApi.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Machine> Machines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().HasOne(x => x.Role).WithMany(x => x.Users);
            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<ApplicationRole>().ToTable("Roles");
        }
    }
}
