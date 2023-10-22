﻿using JapaneseNameGenerator.Entityes;
using Microsoft.EntityFrameworkCore;

namespace JapaneseNameGenerator
{
    public class AppDbContext : DbContext
    {
        public DbSet<FirstNameEntity> FirstNames { get; set; }
        public DbSet<LastNameEntity> LastNames { get; set; }

        public string DbPath { get; }

        public AppDbContext()
        {
            string path = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Join(path, "JapaneseNamesDatabase\\names.sqlite");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstNameEntity>()
                .Property(u => u.Sex)
                .HasConversion<string>()
                .HasMaxLength(1);
        }
    }
}
