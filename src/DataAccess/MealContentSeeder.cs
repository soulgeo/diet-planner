using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class MealContentSeeder
    {
        public static void Seed(EntityTypeBuilder<MealContent> builder)
        {
            builder.HasData(
                // MealId = 1: Oatmeal & Fruit Breakfast
                new MealContent { MealId = 1, FoodId = 13, QuantityGrams = 80 },
                new MealContent { MealId = 1, FoodId = 2, QuantityGrams = 100 },
                new MealContent { MealId = 1, FoodId = 7, QuantityGrams = 10 },
                new MealContent { MealId = 1, FoodId = 29, QuantityGrams = 200 },

                // MealId = 2: Chicken & Quinoa Lunch
                new MealContent { MealId = 2, FoodId = 3, QuantityGrams = 200 },
                new MealContent { MealId = 2, FoodId = 19, QuantityGrams = 200 },
                new MealContent { MealId = 2, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 2, FoodId = 51, QuantityGrams = 30 },

                // MealId = 3: Salmon & Sweet Potato Dinner
                new MealContent { MealId = 3, FoodId = 4, QuantityGrams = 180 },
                new MealContent { MealId = 3, FoodId = 11, QuantityGrams = 250 },
                new MealContent { MealId = 3, FoodId = 10, QuantityGrams = 150 },
                new MealContent { MealId = 3, FoodId = 52, QuantityGrams = 5 },

                // MealId = 4: Yogurt with Honey & Nuts
                new MealContent { MealId = 4, FoodId = 8, QuantityGrams = 200 },
                new MealContent { MealId = 4, FoodId = 27, QuantityGrams = 15 },
                new MealContent { MealId = 4, FoodId = 7, QuantityGrams = 10 },

                // MealId = 5: Spinach Omelette
                new MealContent { MealId = 5, FoodId = 9, QuantityGrams = 180 },
                new MealContent { MealId = 5, FoodId = 10, QuantityGrams = 70 },

                // MealId = 6: Tuna Salad
                new MealContent { MealId = 6, FoodId = 15, QuantityGrams = 150 },
                new MealContent { MealId = 6, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 6, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 6, FoodId = 54, QuantityGrams = 100 },

                // MealId = 7: Turkey & Avocado Toast
                new MealContent { MealId = 7, FoodId = 23, QuantityGrams = 70 },
                new MealContent { MealId = 7, FoodId = 24, QuantityGrams = 100 },
                new MealContent { MealId = 7, FoodId = 21, QuantityGrams = 20 },

                // MealId = 8: Minced Meat with Rice
                new MealContent { MealId = 8, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 8, FoodId = 6, QuantityGrams = 250 },
                new MealContent { MealId = 8, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 8, FoodId = 51, QuantityGrams = 50 },
                new MealContent { MealId = 8, FoodId = 53, QuantityGrams = 50 },

                // MealId = 9: Protein Smoothie
                new MealContent { MealId = 9, FoodId = 29, QuantityGrams = 250 },
                new MealContent { MealId = 9, FoodId = 8, QuantityGrams = 150 },
                new MealContent { MealId = 9, FoodId = 20, QuantityGrams = 100 },

                // MealId = 10: Chickpea Salad
                new MealContent { MealId = 10, FoodId = 25, QuantityGrams = 200 },
                new MealContent { MealId = 10, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 10, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 10, FoodId = 26, QuantityGrams = 50 },

                // MealId = 11: Cottage Cheese with Strawberries
                new MealContent { MealId = 11, FoodId = 22, QuantityGrams = 200 },
                new MealContent { MealId = 11, FoodId = 20, QuantityGrams = 150 },
                new MealContent { MealId = 11, FoodId = 30, QuantityGrams = 50 },

                // MealId = 12: Lentil Soup
                new MealContent { MealId = 12, FoodId = 14, QuantityGrams = 300 },
                new MealContent { MealId = 12, FoodId = 51, QuantityGrams = 50 },
                new MealContent { MealId = 12, FoodId = 53, QuantityGrams = 50 },
                new MealContent { MealId = 12, FoodId = 52, QuantityGrams = 5 },

                // 13: Greek Yogurt Parfait
                new MealContent { MealId = 13, FoodId = 31, QuantityGrams = 200 },
                new MealContent { MealId = 13, FoodId = 30, QuantityGrams = 50 },
                new MealContent { MealId = 13, FoodId = 32, QuantityGrams = 50 },
                new MealContent { MealId = 13, FoodId = 27, QuantityGrams = 10 },

                // 14: Black Bean Burrito Bowl
                new MealContent { MealId = 14, FoodId = 33, QuantityGrams = 200 },
                new MealContent { MealId = 14, FoodId = 19, QuantityGrams = 150 },
                new MealContent { MealId = 14, FoodId = 26, QuantityGrams = 50 },
                new MealContent { MealId = 14, FoodId = 16, QuantityGrams = 50 },

                // 15: Tofu Stir-Fry
                new MealContent { MealId = 15, FoodId = 34, QuantityGrams = 250 },
                new MealContent { MealId = 15, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 15, FoodId = 47, QuantityGrams = 100 },
                new MealContent { MealId = 15, FoodId = 6, QuantityGrams = 200 },
                new MealContent { MealId = 15, FoodId = 51, QuantityGrams = 50 },

                // 16: Edamame Snack
                new MealContent { MealId = 16, FoodId = 35, QuantityGrams = 150 },
                new MealContent { MealId = 16, FoodId = 7, QuantityGrams = 5 },

                // 17: Shrimp & Veggie Skewers
                new MealContent { MealId = 17, FoodId = 36, QuantityGrams = 200 },
                new MealContent { MealId = 17, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 17, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 17, FoodId = 6, QuantityGrams = 200 },

                // 18: Pork Loin & Potato
                new MealContent { MealId = 18, FoodId = 37, QuantityGrams = 150 },
                new MealContent { MealId = 18, FoodId = 55, QuantityGrams = 250 },
                new MealContent { MealId = 18, FoodId = 10, QuantityGrams = 50 },

                // 19: Whole Wheat Pasta Primavera
                new MealContent { MealId = 19, FoodId = 38, QuantityGrams = 220 },
                new MealContent { MealId = 19, FoodId = 5, QuantityGrams = 80 },
                new MealContent { MealId = 19, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 19, FoodId = 51, QuantityGrams = 30 },
                new MealContent { MealId = 19, FoodId = 52, QuantityGrams = 5 },

                // 20: Hummus & Veggies
                new MealContent { MealId = 20, FoodId = 39, QuantityGrams = 80 },
                new MealContent { MealId = 20, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 20, FoodId = 26, QuantityGrams = 80 },
                new MealContent { MealId = 20, FoodId = 23, QuantityGrams = 40 },

                // 21: Walnut & Spinach Salad
                new MealContent { MealId = 21, FoodId = 40, QuantityGrams = 10 },
                new MealContent { MealId = 21, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 21, FoodId = 21, QuantityGrams = 15 },
                new MealContent { MealId = 21, FoodId = 16, QuantityGrams = 50 },

                // 22: Pumpkin Seed Oatmeal
                new MealContent { MealId = 22, FoodId = 13, QuantityGrams = 50 },
                new MealContent { MealId = 22, FoodId = 41, QuantityGrams = 10 },
                new MealContent { MealId = 22, FoodId = 50, QuantityGrams = 5 },
                new MealContent { MealId = 22, FoodId = 29, QuantityGrams = 200 },

                // 23: Pear & Cottage Cheese
                new MealContent { MealId = 23, FoodId = 42, QuantityGrams = 150 },
                new MealContent { MealId = 23, FoodId = 22, QuantityGrams = 150 },

                // 24: Kefir Berry Smoothie
                new MealContent { MealId = 24, FoodId = 43, QuantityGrams = 250 },
                new MealContent { MealId = 24, FoodId = 2, QuantityGrams = 100 },
                new MealContent { MealId = 24, FoodId = 30, QuantityGrams = 50 },
                new MealContent { MealId = 24, FoodId = 50, QuantityGrams = 15 },

                // 25: Tempeh Buddha Bowl
                new MealContent { MealId = 25, FoodId = 44, QuantityGrams = 150 },
                new MealContent { MealId = 25, FoodId = 19, QuantityGrams = 100 },
                new MealContent { MealId = 25, FoodId = 21, QuantityGrams = 15 },
                new MealContent { MealId = 25, FoodId = 16, QuantityGrams = 50 },

                // 26: Sardine Toast
                new MealContent { MealId = 26, FoodId = 45, QuantityGrams = 60 },
                new MealContent { MealId = 26, FoodId = 23, QuantityGrams = 60 },
                new MealContent { MealId = 26, FoodId = 17, QuantityGrams = 50 },

                // 27: Oat Milk Protein Shake
                new MealContent { MealId = 27, FoodId = 46, QuantityGrams = 300 },
                new MealContent { MealId = 27, FoodId = 2, QuantityGrams = 100 },

                // 28: Cauliflower Fried Rice (Vegan)
                new MealContent { MealId = 28, FoodId = 47, QuantityGrams = 200 },
                new MealContent { MealId = 28, FoodId = 34, QuantityGrams = 100 },
                new MealContent { MealId = 28, FoodId = 35, QuantityGrams = 50 },

                // 29: Corn & Black Bean Salad
                new MealContent { MealId = 29, FoodId = 48, QuantityGrams = 120 },
                new MealContent { MealId = 29, FoodId = 33, QuantityGrams = 100 },
                new MealContent { MealId = 29, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 29, FoodId = 21, QuantityGrams = 15 },

                // 30: Dark Chocolate & Almonds
                new MealContent { MealId = 30, FoodId = 49, QuantityGrams = 10 },
                new MealContent { MealId = 30, FoodId = 7, QuantityGrams = 5 },

                // 31: Chia Pudding with Berries
                new MealContent { MealId = 31, FoodId = 50, QuantityGrams = 30 },
                new MealContent { MealId = 31, FoodId = 29, QuantityGrams = 200 },
                new MealContent { MealId = 31, FoodId = 30, QuantityGrams = 50 },
                new MealContent { MealId = 31, FoodId = 27, QuantityGrams = 10 },

                // 32: Grilled Beef & Veggies
                new MealContent { MealId = 32, FoodId = 18, QuantityGrams = 180 },
                new MealContent { MealId = 32, FoodId = 55, QuantityGrams = 250 },
                new MealContent { MealId = 32, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 32, FoodId = 51, QuantityGrams = 50 },

                // Meal 33: Simple Fruit Salad (Breakfast)
                new MealContent { MealId = 33, FoodId = 1, QuantityGrams = 100 },
                new MealContent { MealId = 33, FoodId = 20, QuantityGrams = 100 },
                new MealContent { MealId = 33, FoodId = 30, QuantityGrams = 50 },

                // Meal 34: Lean Turkey Salad (Lunch)
                new MealContent { MealId = 34, FoodId = 24, QuantityGrams = 180 },
                new MealContent { MealId = 34, FoodId = 54, QuantityGrams = 100 },
                new MealContent { MealId = 34, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 34, FoodId = 16, QuantityGrams = 100 },

                // Meal 35: Steamed Salmon & Broccoli (Dinner)
                new MealContent { MealId = 35, FoodId = 4, QuantityGrams = 180 },
                new MealContent { MealId = 35, FoodId = 5, QuantityGrams = 250 },

                // Meal 36: Hummus on Wholemeal Bread (MorningSnack)
                new MealContent { MealId = 36, FoodId = 39, QuantityGrams = 40 },
                new MealContent { MealId = 36, FoodId = 23, QuantityGrams = 40 },

                // Meal 37: Greek Yogurt with Berries (AfternoonSnack)
                new MealContent { MealId = 37, FoodId = 31, QuantityGrams = 150 },
                new MealContent { MealId = 37, FoodId = 20, QuantityGrams = 50 },
                new MealContent { MealId = 37, FoodId = 30, QuantityGrams = 50 }
            );
        }
    }
}
