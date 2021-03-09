using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cinema_pro.Models;

namespace Cinema_pro.Data
{
    public class Cinema_proDatabase : DbContext
    {
        public Cinema_proDatabase (DbContextOptions<Cinema_proDatabase> options)
            : base(options)
        {
        }

        public DbSet<Cinema_pro.Models.Cinema> Cinema { get; set; }

        public DbSet<Cinema_pro.Models.Movie> Movie { get; set; }

        public DbSet<Cinema_pro.Models.Kids_Collection> Kids_Collection { get; set; }

        public DbSet<Cinema_pro.Models.Show> Show { get; set; }
    }
}
