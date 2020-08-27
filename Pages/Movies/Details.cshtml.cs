using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_RazorPages_Movie.Data;
using WebApplication_RazorPages_Movie.Models;

namespace WebApplication_RazorPages_Movie.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication_RazorPages_Movie.Data.WebApplication_RazorPages_MovieContext _context;

        public DetailsModel(WebApplication_RazorPages_Movie.Data.WebApplication_RazorPages_MovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
