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
                new Meal { MealId = 12, Name = "Lentil Soup", MealType = MealType.Lunch },
                new Meal { MealId = 13, Name = "Greek Yogurt Parfait", MealType = MealType.Breakfast },
                new Meal { MealId = 14, Name = "Black Bean Burrito Bowl", MealType = MealType.Lunch },
                new Meal { MealId = 15, Name = "Tofu Stir-Fry", MealType = MealType.Dinner },
                new Meal { MealId = 16, Name = "Edamame Snack", MealType = MealType.MorningSnack },
                new Meal { MealId = 17, Name = "Shrimp & Veggie Skewers", MealType = MealType.Dinner },
                new Meal { MealId = 18, Name = "Pork Loin & Sweet Potato", MealType = MealType.Dinner },
                new Meal { MealId = 19, Name = "Whole Wheat Pasta Primavera", MealType = MealType.Lunch },
                new Meal { MealId = 20, Name = "Hummus & Veggies", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 21, Name = "Walnut & Spinach Salad", MealType = MealType.Lunch },
                new Meal { MealId = 22, Name = "Pumpkin Seed Oatmeal", MealType = MealType.Breakfast },
                new Meal { MealId = 23, Name = "Pear & Cottage Cheese", MealType = MealType.MorningSnack },
                new Meal { MealId = 24, Name = "Kefir Berry Smoothie", MealType = MealType.Breakfast },
                new Meal { MealId = 25, Name = "Tempeh Buddha Bowl", MealType = MealType.Lunch },
                new Meal { MealId = 26, Name = "Sardine Toast", MealType = MealType.MorningSnack },
                new Meal { MealId = 27, Name = "Oat Milk Protein Shake", MealType = MealType.Breakfast },
                new Meal { MealId = 28, Name = "Cauliflower Fried Rice (Vegan)", MealType = MealType.Lunch },
                new Meal { MealId = 29, Name = "Corn & Black Bean Salad", MealType = MealType.Dinner },
                new Meal { MealId = 30, Name = "Dark Chocolate & Almonds", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 31, Name = "Chia Pudding with Berries", MealType = MealType.Breakfast },
                new Meal { MealId = 32, Name = "Grilled Beef & Veggies", MealType = MealType.Dinner },

                // New Low-Fat Meals
                new Meal { MealId = 33, Name = "Simple Fruit Salad", MealType = MealType.Breakfast },
                new Meal { MealId = 34, Name = "Lean Turkey Salad", MealType = MealType.Lunch },
                new Meal { MealId = 35, Name = "Steamed Salmon & Broccoli", MealType = MealType.Dinner },
                new Meal { MealId = 36, Name = "Hummus on Wholemeal Bread", MealType = MealType.MorningSnack },
                new Meal { MealId = 37, Name = "Greek Yogurt with Berries", MealType = MealType.AfternoonSnack }
            );
        }
    }
}
