using Microsoft.EntityFrameworkCore;
using WebAppCoreMVC.Models;

namespace WebAppCoreMVC.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> context) : base(context)
        {
        }

        /// <summary>
        /// List of movies.
        /// </summary>
        public virtual DbSet<Movie> Movies { get; set; }
    }
}
