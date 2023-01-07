using batubilet.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace batubilet.data.Concrete
{
    public class BiletContext : DbContext
    {

        public DbSet<Bilet> Bilets { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=biletDb");
        }
    }
}
