using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace RazorCrud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudGameContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                 context.Game.AddRange(
                    new Game
                    {
                        Title = "Star Wars Jedi: Fallen Order",
                        Developer = "Respawn Entertainment",
                        Genre = "Action Adventure",
                        ReleaseDate = DateTime.Parse("2019-11-15"),
                    },
                    new Game
                    {
                        Title = "Rise of The Tomb raider",
                        Developer = "Crystal Dynamics",
                        Genre = "Action Adventure",
                        ReleaseDate = DateTime.Parse("2015-11-10"),
                    }
       
                 );
                context.SaveChanges();
            }
        }
        
        
    }
}