using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteRazorPages.Models;

namespace WebSiteRazorPages.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebSiteRazorPagesContext(
                serviceProvider.GetRequiredService<DbContextOptions<WebSiteRazorPagesContext>>()))
            {
                // Look for any movies.
                if (context.Activity.Any())
                {
                    return;   // DB has been seeded
                }

                context.Activity.AddRange(
                    new Activity
                    {
                        Title = "Activity1",
                        
                        Price = 7.99M
                    },

                    new Activity
                    {
                        Title = "Activity2 ",
                        
                        Price = 8.99M
                    },

                    new Activity
                    {
                        Title = "Activity3",
                        
                        Price = 9.99M
                    },

                    new Activity
                    {
                        Title = "Activity4",
                       
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
