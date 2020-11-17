using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {

        }

        public DbSet<RazorPagesMovie.Model.Movie> Movie { get; set; }
    }
}