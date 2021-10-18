using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTC1070.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LTC1070.Models.Movie> Movie { get; set; }

        public DbSet<LTC1070.Models.LTC070> LTC070 { get; set; }
    }
