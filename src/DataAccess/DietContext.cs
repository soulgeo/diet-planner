using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace DietPlanner.DataAccess
{
    public class DietContext : DbContext
    {
        private static readonly DbContextOptions<DietContext> _options = new DbContextOptionsBuilder<DietContext>()
            .UseInMemoryDatabase(databaseName: "DietPlannerTest")
            .Options;

        public DietContext() : base(_options)
        {
            Database.EnsureCreated();
        }

        public DietContext(DbContextOptions<DietContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealContent> MealContents { get; set; }

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
