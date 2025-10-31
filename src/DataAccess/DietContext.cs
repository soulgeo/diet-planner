using System;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DietPlanner.DataAccess
{
    public class DietContext : DbContext
    {
        public DietContext()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Food> Foods { get; set; } = null!;
        public DbSet<Meal> Meals { get; set; } = null!;
        public DbSet<MealContent> MealContents { get; set; } = null!;

        private readonly string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "DataAccess", "DietPlanner.db"));

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.UseInMemoryDatabase(databaseName: "DietPlannerTest");
#else
            optionsBuilder.UseSqlite($"Data Source={path}");
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealContent>()
                .HasKey(mf => new { mf.MealId, mf.FoodId });
            modelBuilder.Entity<Food>()
                .Property(f => f.Allergen)
                .HasConversion<string>();
            FoodSeeder.Seed(modelBuilder.Entity<Food>());
            MealSeeder.Seed(modelBuilder.Entity<Meal>());
            MealContentSeeder.Seed(modelBuilder.Entity<MealContent>());
        }
    }
}
