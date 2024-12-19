using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Document> Document { get; set; }
        public DbSet<Adherent> Adherent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\\ua33\\amira_kenza_yasmineUA2\\my_db.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Document>().HasKey(d => d.ISBN);
            modelBuilder.Entity<Adherent>().HasKey(u => u.Id);
        }
    }
}
