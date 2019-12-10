using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowFieldByUser
{
    public class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("admin@xyz.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "admin@xyz.com",
                    Email = "admin@xyz.com"
                };
                IdentityResult result = userManager.CreateAsync(user, "#A6qqbzjv").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }


        // 2de poging mix van vorige 

        public static class SeedData
        {

            public static async Task InitializeAsync(IServiceProvider serviceProvider)
            {
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                await EnsureRolesAsync(roleManager);

                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                await EnsureTestAdminAsync(userManager);
            }

            private static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager)
            {
                var alreadyExists = await roleManager
                .RoleExistsAsync(Constants.AdministratorRole);
                if (alreadyExists) return;
                await roleManager.CreateAsync(
                new IdentityRole(Constants.AdministratorRole));
            }

            public static class Constants
            {
                public const string AdministratorRole = "Administrator";
            }

            private static async Task EnsureTestAdminAsync(UserManager<IdentityUser> userManager)
            {
                var testAdmin = await userManager.Users
                .Where(x => x.UserName == "admin@todo.local").SingleOrDefaultAsync();
                if (testAdmin != null) return;
                testAdmin = new IdentityUser
                {
                    UserName = "admin@todo.local",
                    Email = "admin@todo.local"
                };
                await userManager.CreateAsync(
                testAdmin, "NotSecure123!!");
                await userManager.AddToRoleAsync(
                testAdmin, Constants.AdministratorRole);
            }
        }

    }
}
