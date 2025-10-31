using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class MealSeeder
    {
        public static void Seed(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal { MealId = 1, Name = "Oatmeal & Fruit Breakfast", MealType = MealType.Breakfast },
                new Meal { MealId = 2, Name = "Chicken & Quinoa Lunch", MealType = MealType.Lunch },
                new Meal { MealId = 3, Name = "Salmon & Sweet Potato Dinner", MealType = MealType.Dinner },
                new Meal { MealId = 4, Name = "Yogurt with Honey & Nuts", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 5, Name = "Spinach Omelette", MealType = MealType.Breakfast },
                new Meal { MealId = 6, Name = "Tuna Salad", MealType = MealType.Lunch },
                new Meal { MealId = 7, Name = "Turkey & Avocado Toast", MealType = MealType.MorningSnack },
                new Meal { MealId = 8, Name = "Minced Meat with Rice", MealType = MealType.Lunch },
                new Meal { MealId = 9, Name = "Protein Smoothie", MealType = MealType.Breakfast },
                new Meal { MealId = 10, Name = "Chickpea Salad", MealType = MealType.Dinner },
                new Meal { MealId = 11, Name = "Cottage Cheese with Strawberries", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 12, Name = "Lentil Soup", MealType = MealType.Lunch }
            );
        }
    }
}