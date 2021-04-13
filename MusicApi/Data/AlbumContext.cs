using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class AlbumContext : DbContext
    {

        public AlbumContext(DbContextOptions<AlbumContext> options)
        : base(options)
        {
            
        }
        
        public DbSet<Album> Albums { get; set; }
        
        public DbSet<Artist> Artists { get; set; }
    }
}