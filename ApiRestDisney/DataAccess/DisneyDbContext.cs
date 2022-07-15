using ApiRestDisney.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace ApiRestDisney.DataAccess
{
    public class DisneyDbContext: DbContext
    {
        public DisneyDbContext(DbContextOptions<DisneyDbContext> options): base(options)
        {

        }
        // TODO: Add DbSets (Tables of our Data Base)
        public DbSet<Character>? Characters { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<MovieOrSeries>? MovieOrSeries { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
