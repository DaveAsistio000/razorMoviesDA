#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorMoviesDA.Models;

namespace razorMoviesDA.Data
{
    public class razorMoviesDAContext : DbContext
    {
        public razorMoviesDAContext (DbContextOptions<razorMoviesDAContext> options)
            : base(options)
        {
        }

        public DbSet<razorMoviesDA.Models.Movie> Movie { get; set; }
    }
}
