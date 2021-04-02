using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudAlbumContext : DbContext
    {
        public RazorCrudAlbumContext (DbContextOptions<RazorCrudAlbumContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Album> Album { get; set; }
    }
