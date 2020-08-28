using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_RazorPages_Movie.Data;

namespace WebApplication_RazorPages_Movie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication_RazorPages_MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<WebApplication_RazorPages_MovieContext>>()))
            {
                if (context.Movie.Any()) // Look for any movies.
                {
                    return; // DB already exist
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("12.02.1989"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("13.03.1984"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("23.02.1986"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("15.04.1959"),
                        Genre = "Western",
                        Price = 3.99M
                    });
                context.SaveChanges();
            }
        }
    }
}
