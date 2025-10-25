using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace DietPlanner.DataAccess
{
    public class DietContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealFood> MealFoods { get; set; }

        private string path = @"C:\Users\User\Documents\sqlite\DietPlanner.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealFood>()
                .HasKey(mf => new { mf.MealId, mf.FoodId });
            FoodSeeder.Seed(modelBuilder.Entity<Food>());
            MealSeeder.Seed(modelBuilder.Entity<Meal>());
            MealFoodSeeder.Seed(modelBuilder.Entity<MealFood>());
        }
    }
}