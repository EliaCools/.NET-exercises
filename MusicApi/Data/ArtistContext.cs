using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(DbContextOptions<ArtistContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
    }
}