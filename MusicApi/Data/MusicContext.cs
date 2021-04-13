using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

  
    }
}