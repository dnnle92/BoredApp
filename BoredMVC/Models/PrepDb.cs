using BoredMVC.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoredMVC.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
            }
        }

        public static void SeedData(ApplicationDbContext context)
        {
            System.Console.WriteLine("Applying Migrations..");

            context.Database.Migrate();

            //if (!context.Users.Any())
            //{
            //    System.Console.WriteLine("Seeding User Data");
            //    context.Users.AddRange(
            //        new IdentityUser()
            //        {

            //        });
            //    context.SaveChanges();
            //}
            //else
            //{
            //    System.Console.WriteLine("User Data Present");
            //}
        }
    }
}

