using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMoviee.Models;

namespace RazorPageMoviee.Data
{
    public class RazorPageMovieeContext : DbContext
    {
        public RazorPageMovieeContext (DbContextOptions<RazorPageMovieeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMoviee.Models.Movie> Movie { get; set; } = default!;
    }
}
