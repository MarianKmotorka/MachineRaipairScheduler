using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi
{
    public static class StartupHelpers
    {
        public static async Task CreateUserRoles(this IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            if (!await roleManager.RoleExistsAsync(Roles.SysAdmin))
                await roleManager.CreateAsync(new ApplicationRole(Roles.SysAdmin));

            if (!await roleManager.RoleExistsAsync(Roles.Employee))
                await roleManager.CreateAsync(new ApplicationRole(Roles.Employee));

            if (!await roleManager.RoleExistsAsync(Roles.PlanningManager))
                await roleManager.CreateAsync(new ApplicationRole(Roles.PlanningManager));

            if (!await roleManager.RoleExistsAsync(Roles.Technician))
                await roleManager.CreateAsync(new ApplicationRole(Roles.Technician));

            var user = new ApplicationUser
            {
                Email = "admin@test.com",
                UserName = "admin@test.com",
                FirstName = "ADMIN",
                LastName="ADMIN",
                BirthCertificateNumber = "00000000/0000",
                EmailConfirmed = true,
                LockoutEnabled = false
            };

            var existingUser = await userManager.FindByEmailAsync(user.Email);

            if (existingUser is null)
            {
                await userManager.CreateAsync(user, "Vinco123");
                await userManager.AddToRoleAsync(user, Roles.SysAdmin);
            }
        }
    }
}
