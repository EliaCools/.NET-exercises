using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudGameContext : DbContext
    {
        public RazorCrudGameContext (DbContextOptions<RazorCrudGameContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Game> Game { get; set; }
    }
