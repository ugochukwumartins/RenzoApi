using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Renzorapi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Renzorapi.Data
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Poems.Any())
                {
                    context.Poems.AddRange(new Poem()
                    {
                        Title = "Life is Beautiful",
                        Catption = "have u tested the lord goodness",
                        Body = "God is good oo how he saved my life",
                        Dateadded = DateTime.Now
                    },
                    new Poem()
                    {
                        Title = "Life is Beautiful",
                        Catption = "have u tested the lord goodness",
                        Body = "God is good oo how he saved my life",
                        Dateadded = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
