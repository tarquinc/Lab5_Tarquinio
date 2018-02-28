using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Lab5_Tarquinio.Models
{
    public class Lab5_TarquinioContext : DbContext
    {
        public Lab5_TarquinioContext (DbContextOptions<Lab5_TarquinioContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
