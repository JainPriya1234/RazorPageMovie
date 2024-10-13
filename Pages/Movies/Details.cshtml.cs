using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMoviee.Data;
using RazorPageMoviee.Models;

namespace RazorPageMoviee.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageMoviee.Data.RazorPageMovieeContext _context;

        public DetailsModel(RazorPageMoviee.Data.RazorPageMovieeContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
