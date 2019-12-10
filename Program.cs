using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShowFieldByUser;
using Microsoft.Extensions.DependencyInjection;
using ShowFieldByUser.Data;
using Microsoft.AspNetCore.Identity;
using ShowFieldByUser.Models;
using MyIdentityDataInitializer;

namespace ShowFieldByUser
{
    public class Program
    {
        public static void Main(string[] args)
        {
          var host =  CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    var userManager = serviceProvider.
        GetRequiredService<UserManager<MyIdentityUser>>();

                    var roleManager = serviceProvider.
        GetRequiredService<RoleManager<MyIdentityRole>>();

                    MyIdentityDataInitializer2.SeedData(userManager, roleManager);
                }
                catch
                {

                }
            }
            host.Run();


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        

       


        

    }}

