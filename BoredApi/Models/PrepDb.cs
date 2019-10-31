using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoredApi.Data.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BoredApi.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<BoredDbContext>());
            }
        }

        public static void SeedData(BoredDbContext context)
        {
            System.Console.WriteLine("Applying Migrations..");

            context.Database.Migrate();

            if (!context.Responses.Any())
            {
                System.Console.WriteLine("Seeding Data");
                context.Responses.AddRange(
                    new Response() { 
                        Activity= "Learn how to play a new sport",
                        Participants = 1,
                        Price="$",
                        Type="recreational",
                        Accessibility = 2
                    });
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Data Present");
            }
        }
    }
}
