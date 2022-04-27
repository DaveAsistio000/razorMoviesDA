#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorMoviesDA.Data;
using razorMoviesDA.Models;

namespace razorMoviesDA.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly razorMoviesDA.Data.razorMoviesDAContext _context;

        public IndexModel(razorMoviesDA.Data.razorMoviesDAContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
