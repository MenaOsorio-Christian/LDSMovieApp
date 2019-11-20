using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LdsMovieApp.Models
{
    public class LdsMovieAppContext : DbContext
    {
        public LdsMovieAppContext (DbContextOptions<LdsMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<LdsMovieApp.Models.Movie> Movie { get; set; }
    }
}
