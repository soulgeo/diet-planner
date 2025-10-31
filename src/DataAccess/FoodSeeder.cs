using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class FoodSeeder
    {
        public static void Seed(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    FoodId = 1,
                    Name = "Apple",
                    Calories = 52,
                    Protein = 0.3,
                    Carbs = 14,
                    Fat = 0.2,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 2,
                    Name = "Banana",
                    Calories = 89,
                    Protein = 1.1,
                    Carbs = 23,
                    Fat = 0.3,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 3,
                    Name = "Chicken Breast",
                    Calories = 165,
                    Protein = 31,
                    Carbs = 0,
                    Fat = 3.6,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 4,
                    Name = "Salmon",
                    Calories = 208,
                    Protein = 20,
                    Carbs = 0,
                    Fat = 13,
                    Allergen = Allergen.Fish
                },
                new Food
                {
                    FoodId = 5,
                    Name = "Broccoli",
                    Calories = 55,
                    Protein = 3.7,
                    Carbs = 11,
                    Fat = 0.6,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 6,
                    Name = "Brown Rice",
                    Calories = 111,
                    Protein = 2.6,
                    Carbs = 23,
                    Fat = 0.9,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 7,
                    Name = "Almonds",
                    Calories = 579,
                    Protein = 21,
                    Carbs = 22,
                    Fat = 49,
                    Allergen = Allergen.Nuts
                },
                new Food
                {
                    FoodId = 8,
                    Name = "Strained Yogurt 2%",
                    Calories = 73,
                    Protein = 10,
                    Carbs = 3.6,
                    Fat = 2,
                    Allergen = Allergen.Dairy
                },
                new Food
                {
                    FoodId = 9,
                    Name = "Egg",
                    Calories = 155,
                    Protein = 13,
                    Carbs = 1.1,
                    Fat = 11,
                    Allergen = Allergen.Egg
                },
                new Food
                {
                    FoodId = 10,
                    Name = "Spinach",
                    Calories = 23,
                    Protein = 2.9,
                    Carbs = 3.6,
                    Fat = 0.4,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 11,
                    Name = "Sweet Potato",
                    Calories = 86,
                    Protein = 1.6,
                    Carbs = 20,
                    Fat = 0.1,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 12,
                    Name = "Olive Oil",
                    Calories = 884,
                    Protein = 0,
                    Carbs = 0,
                    Fat = 100,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 13,
                    Name = "Oats",
                    Calories = 389,
                    Protein = 16.9,
                    Carbs = 66.3,
                    Fat = 6.9,
                    Allergen = Allergen.Gluten
                },
                new Food
                {
                    FoodId = 14,
                    Name = "Lentils",
                    Calories = 116,
                    Protein = 9,
                    Carbs = 20,
                    Fat = 0.4,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 15,
                    Name = "Tuna in Water",
                    Calories = 132,
                    Protein = 28,
                    Carbs = 0,
                    Fat = 1.3,
                    Allergen = Allergen.Fish
                },
                new Food
                {
                    FoodId = 16,
                    Name = "Cucumber",
                    Calories = 15,
                    Protein = 0.7,
                    Carbs = 3.6,
                    Fat = 0.1,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 17,
                    Name = "Tomato",
                    Calories = 18,
                    Protein = 0.9,
                    Carbs = 3.9,
                    Fat = 0.2,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 18,
                    Name = "Minced Beef (90/10)",
                    Calories = 217,
                    Protein = 19,
                    Carbs = 0,
                    Fat = 15,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 19,
                    Name = "Quinoa",
                    Calories = 120,
                    Protein = 4.4,
                    Carbs = 21,
                    Fat = 1.9,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 20,
                    Name = "Strawberries",
                    Calories = 32,
                    Protein = 0.7,
                    Carbs = 7.7,
                    Fat = 0.3,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 21,
                    Name = "Avocado",
                    Calories = 160,
                    Protein = 2,
                    Carbs = 9,
                    Fat = 15,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 22,
                    Name = "Cottage Cheese",
                    Calories = 98,
                    Protein = 11,
                    Carbs = 3.4,
                    Fat = 4.3,
                    Allergen = Allergen.Dairy
                },
                new Food
                {
                    FoodId = 23,
                    Name = "Wholemeal Bread",
                    Calories = 247,
                    Protein = 13,
                    Carbs = 41,
                    Fat = 3.4,
                    Allergen = Allergen.Gluten
                },
                new Food
                {
                    FoodId = 24,
                    Name = "Boiled Turkey",
                    Calories = 135,
                    Protein = 29,
                    Carbs = 0,
                    Fat = 1,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 25,
                    Name = "Chickpeas",
                    Calories = 164,
                    Protein = 8.9,
                    Carbs = 27,
                    Fat = 2.6,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 26,
                    Name = "Red Pepper",
                    Calories = 31,
                    Protein = 1,
                    Carbs = 6,
                    Fat = 0.3,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 27,
                    Name = "Honey",
                    Calories = 304,
                    Protein = 0.3,
                    Carbs = 82,
                    Fat = 0,
                    Allergen = Allergen.None
                },
                new Food
                {
                    FoodId = 28,
                    Name = "Peanut Butter",
                    Calories = 588,
                    Protein = 25,
                    Carbs = 20,
                    Fat = 50,
                    Allergen = Allergen.Nuts
                },
                new Food
                {
                    FoodId = 29,
                    Name = "Milk 1.5%",
                    Calories = 47,
                    Protein = 3.4,
                    Carbs = 5,
                    Fat = 1.5,
                    Allergen = Allergen.Dairy
                },
                new Food
                {
                    FoodId = 30,
                    Name = "Blueberries",
                    Calories = 57,
                    Protein = 0.7,
                    Carbs = 14,
                    Fat = 0.3,
                    Allergen = Allergen.None
                }
            );
        }
    }
}