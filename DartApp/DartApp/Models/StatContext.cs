using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DartApp.Models
{
    public class StatContext : DbContext
    {
        private string connectionString;

        public StatContext()
        {
            string databasePath = Path.Combine(FileSystem.AppDataDirectory, "DartSQLite.db3");
            connectionString = $"Filename={databasePath}";

            Database.EnsureCreated();

        }

        public DbSet<Stat> Stats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
