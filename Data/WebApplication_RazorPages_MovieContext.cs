using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_RazorPages_Movie.Models;

namespace WebApplication_RazorPages_Movie.Data
{
    public class WebApplication_RazorPages_MovieContext : DbContext
    {
        public WebApplication_RazorPages_MovieContext (DbContextOptions<WebApplication_RazorPages_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_RazorPages_Movie.Models.Movie> Movie { get; set; }
    }
}
