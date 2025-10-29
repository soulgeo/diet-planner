using System;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DietPlanner.DataAccess
{
    public class DietContext : DbContext
    {
        public DbSet<Food> Foods { get; set; } = null!;
        public DbSet<Meal> Meals { get; set; } = null!;
        public DbSet<MealContent> MealContents { get; set; } = null!;

        private string path = Path.Combine(
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName,
            "DataAccess", "DietPlanner.db"
            );


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealContent>()
                .HasKey(mf => new { mf.MealId, mf.FoodId });
            FoodSeeder.Seed(modelBuilder.Entity<Food>());
            MealSeeder.Seed(modelBuilder.Entity<Meal>());
            MealContentSeeder.Seed(modelBuilder.Entity<MealContent>());
        }
    }
}
