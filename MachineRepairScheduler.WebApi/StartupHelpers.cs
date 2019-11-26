using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi
{
    public static class StartupHelpers
    {
        public static async Task CreateUserRoles(this IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(Roles.SysAdmin))
                await roleManager.CreateAsync(new IdentityRole(Roles.SysAdmin));

            if (!await roleManager.RoleExistsAsync(Roles.Employee))
                await roleManager.CreateAsync(new IdentityRole(Roles.Employee));

            if (!await roleManager.RoleExistsAsync(Roles.PlanningManager))
                await roleManager.CreateAsync(new IdentityRole(Roles.PlanningManager));

            if (!await roleManager.RoleExistsAsync(Roles.Technician))
                await roleManager.CreateAsync(new IdentityRole(Roles.Technician));
        }
    }
}
