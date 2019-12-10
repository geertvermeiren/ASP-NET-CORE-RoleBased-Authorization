using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIdentityDataInitializer
{
    public class MyIdentityDataInitializer2
    {
        public static void SeedData(UserManager<MyIdentityUser> userManager,RoleManager<MyIdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<MyIdentityUser> userManager)
    {
        if (userManager.FindByNameAsync("user6").Result == null)
        {
            MyIdentityUser user = new MyIdentityUser();
            user.UserName = "user6";
            user.Email = "user6@admin.com";
          

            IdentityResult result = userManager.CreateAsync
            (user, "#A6qqbzjv").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user,
                                    "Administrator").Wait();
            }
        }


        if (userManager.FindByNameAsync
    ("user7").Result == null)
        {
            MyIdentityUser user = new MyIdentityUser();
            user.UserName = "user7";
            user.Email = "user7@admin.com";
           

            IdentityResult result = userManager.CreateAsync
            (user, "#A6qqbzjv").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user,
                                    "Administrator").Wait();
            }
        }
    }

        public static void SeedRoles(RoleManager<MyIdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync
        ("User").Result)
            {
                MyIdentityRole role = new MyIdentityRole();
                role.Name = "User";
                role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync
        ("Administrator").Result)
            {
                MyIdentityRole role = new MyIdentityRole();
                role.Name = "Administrator";
                role.Description = "Perform all the operations.";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }


    }



}
