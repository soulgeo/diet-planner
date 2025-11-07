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
                new Meal { MealId = 37, Name = "Greek Yogurt with Berries", MealType = MealType.AfternoonSnack },

                new Meal { MealId = 38, Name = "Chicken and Vegetable Stir-fry", MealType = MealType.Dinner },
                new Meal { MealId = 39, Name = "Hearty Beef and Vegetable Stew", MealType = MealType.Dinner },
                new Meal { MealId = 40, Name = "Scrambled Eggs with Spinach and Toast", MealType = MealType.Breakfast },
                new Meal { MealId = 41, Name = "Quinoa Salad with Chickpeas and Veggies", MealType = MealType.Lunch },
                new Meal { MealId = 42, Name = "Turkey Meatballs with Whole Wheat Pasta", MealType = MealType.Dinner },
                new Meal { MealId = 43, Name = "Apple Slices with Peanut Butter", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 44, Name = "Hard-Boiled Eggs", MealType = MealType.MorningSnack },
                new Meal { MealId = 45, Name = "Chicken Salad Sandwich", MealType = MealType.Lunch },
                new Meal { MealId = 46, Name = "Baked Salmon with Roasted Potatoes and Carrots", MealType = MealType.Dinner },
                new Meal { MealId = 47, Name = "Overnight Oats with Berries", MealType = MealType.Breakfast },
                new Meal { MealId = 48, Name = "Simple Chicken and Rice", MealType = MealType.Lunch },

                // 30 New Meals
                new Meal { MealId = 49, Name = "Tofu Scramble", MealType = MealType.Breakfast },
                new Meal { MealId = 50, Name = "Cottage Cheese with Pear and Almonds", MealType = MealType.Breakfast },
                new Meal { MealId = 51, Name = "Egg White Omelette with Turkey and Spinach", MealType = MealType.Breakfast },
                new Meal { MealId = 52, Name = "Breakfast Burrito", MealType = MealType.Breakfast },
                new Meal { MealId = 53, Name = "Smoked Salmon on Wholemeal Bread", MealType = MealType.Breakfast },
                new Meal { MealId = 54, Name = "Quinoa Porridge with Berries", MealType = MealType.Breakfast },
                new Meal { MealId = 55, Name = "Grilled Chicken Caesar Salad", MealType = MealType.Lunch },
                new Meal { MealId = 56, Name = "Beef and Broccoli Stir-fry", MealType = MealType.Lunch },
                new Meal { MealId = 57, Name = "Shrimp and Avocado Salad", MealType = MealType.Lunch },
                new Meal { MealId = 58, Name = "Lentil and Vegetable Curry", MealType = MealType.Lunch },
                new Meal { MealId = 59, Name = "Tempeh Sandwich on Wholemeal Bread", MealType = MealType.Lunch },
                new Meal { MealId = 60, Name = "Greek Salad with Chicken", MealType = MealType.Lunch },
                new Meal { MealId = 61, Name = "Stuffed Bell Peppers with Turkey and Quinoa", MealType = MealType.Lunch },
                new Meal { MealId = 62, Name = "Black Bean Burgers", MealType = MealType.Lunch },
                new Meal { MealId = 63, Name = "Pork Chops with Apple and Sweet Potato", MealType = MealType.Dinner },
                new Meal { MealId = 64, Name = "Baked Shrimp with Broccoli", MealType = MealType.Dinner },
                new Meal { MealId = 65, Name = "Chicken and Black Bean Enchiladas", MealType = MealType.Dinner },
                new Meal { MealId = 66, Name = "Vegan Lentil Shepherd's Pie", MealType = MealType.Dinner },
                new Meal { MealId = 67, Name = "Pork and Apple Skewers", MealType = MealType.Dinner },
                new Meal { MealId = 68, Name = "Lemon Herb Chicken with Roasted Potatoes", MealType = MealType.Dinner },
                new Meal { MealId = 69, Name = "Spicy Shrimp with Cauliflower Rice", MealType = MealType.Dinner },
                new Meal { MealId = 70, Name = "Beef and Carrot Stew", MealType = MealType.Dinner },
                new Meal { MealId = 71, Name = "Cucumber Sticks with Hummus", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 72, Name = "A handful of Walnuts", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 73, Name = "Avocado on Wholemeal Bread", MealType = MealType.MorningSnack },
                new Meal { MealId = 74, Name = "Edamame Side", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 75, Name = "A single Pear", MealType = MealType.MorningSnack },
                new Meal { MealId = 76, Name = "Cottage Cheese with Tomato", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 77, Name = "A small bowl of Blueberries", MealType = MealType.MorningSnack },
                new Meal { MealId = 78, Name = "Single Hard-boiled egg", MealType = MealType.MorningSnack }
            );
        }
    }
}
