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
                new MealContent { MealId = 1, FoodId = 13, QuantityGrams = 50 },
                new MealContent { MealId = 1, FoodId = 2, QuantityGrams = 100 },
                new MealContent { MealId = 1, FoodId = 7, QuantityGrams = 15 },
                new MealContent { MealId = 1, FoodId = 29, QuantityGrams = 150 },

                // MealId = 2: Chicken & Quinoa Lunch
                new MealContent { MealId = 2, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 2, FoodId = 19, QuantityGrams = 180 },
                new MealContent { MealId = 2, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 2, FoodId = 12, QuantityGrams = 10 },

                // MealId = 3: Salmon & Sweet Potato Dinner
                new MealContent { MealId = 3, FoodId = 4, QuantityGrams = 150 },
                new MealContent { MealId = 3, FoodId = 11, QuantityGrams = 200 },
                new MealContent { MealId = 3, FoodId = 10, QuantityGrams = 150 },

                // MealId = 4: Yogurt with Honey & Nuts
                new MealContent { MealId = 4, FoodId = 8, QuantityGrams = 200 },
                new MealContent { MealId = 4, FoodId = 27, QuantityGrams = 15 },
                new MealContent { MealId = 4, FoodId = 7, QuantityGrams = 20 },

                // MealId = 5: Spinach Omelette
                new MealContent { MealId = 5, FoodId = 9, QuantityGrams = 120 },
                new MealContent { MealId = 5, FoodId = 10, QuantityGrams = 70 },
                new MealContent { MealId = 5, FoodId = 12, QuantityGrams = 5 },

                // MealId = 6: Tuna Salad
                new MealContent { MealId = 6, FoodId = 15, QuantityGrams = 100 },
                new MealContent { MealId = 6, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 6, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 6, FoodId = 12, QuantityGrams = 15 },

                // MealId = 7: Turkey & Avocado Toast
                new MealContent { MealId = 7, FoodId = 23, QuantityGrams = 70 },
                new MealContent { MealId = 7, FoodId = 24, QuantityGrams = 60 },
                new MealContent { MealId = 7, FoodId = 21, QuantityGrams = 50 },

                // MealId = 8: Minced Meat with Rice
                new MealContent { MealId = 8, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 8, FoodId = 6, QuantityGrams = 200 },
                new MealContent { MealId = 8, FoodId = 17, QuantityGrams = 100 },

                // MealId = 9: Protein Smoothie
                new MealContent { MealId = 9, FoodId = 29, QuantityGrams = 250 },
                new MealContent { MealId = 9, FoodId = 8, QuantityGrams = 100 },
                new MealContent { MealId = 9, FoodId = 20, QuantityGrams = 50 },
                new MealContent { MealId = 9, FoodId = 28, QuantityGrams = 20 },

                // MealId = 10: Chickpea Salad
                new MealContent { MealId = 10, FoodId = 25, QuantityGrams = 150 },
                new MealContent { MealId = 10, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 10, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 10, FoodId = 26, QuantityGrams = 50 },
                new MealContent { MealId = 10, FoodId = 12, QuantityGrams = 20 },

                // MealId = 11: Cottage Cheese with Strawberries
                new MealContent { MealId = 11, FoodId = 22, QuantityGrams = 150 },
                new MealContent { MealId = 11, FoodId = 20, QuantityGrams = 100 },
                new MealContent { MealId = 11, FoodId = 30, QuantityGrams = 50 },

                // MealId = 12: Lentil Soup
                new MealContent { MealId = 12, FoodId = 14, QuantityGrams = 250 },
                new MealContent { MealId = 12, FoodId = 12, QuantityGrams = 10 },

                // 13: Greek Yogurt Parfait
                new MealContent { MealId = 13, FoodId = 31, QuantityGrams = 150 },
                new MealContent { MealId = 13, FoodId = 30, QuantityGrams = 50 },
                new MealContent { MealId = 13, FoodId = 32, QuantityGrams = 40 },
                new MealContent { MealId = 13, FoodId = 27, QuantityGrams = 10 },

                // 14: Black Bean Burrito Bowl
                new MealContent { MealId = 14, FoodId = 33, QuantityGrams = 150 },
                new MealContent { MealId = 14, FoodId = 19, QuantityGrams = 100 },
                new MealContent { MealId = 14, FoodId = 26, QuantityGrams = 50 },
                new MealContent { MealId = 14, FoodId = 16, QuantityGrams = 50 },
                new MealContent { MealId = 14, FoodId = 12, QuantityGrams = 10 },

                // 15: Tofu Stir-Fry
                new MealContent { MealId = 15, FoodId = 34, QuantityGrams = 200 },
                new MealContent { MealId = 15, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 15, FoodId = 47, QuantityGrams = 100 },
                new MealContent { MealId = 15, FoodId = 12, QuantityGrams = 10 },
                new MealContent { MealId = 15, FoodId = 6, QuantityGrams = 150 },

                // 16: Edamame Snack
                new MealContent { MealId = 16, FoodId = 35, QuantityGrams = 100 },
                new MealContent { MealId = 16, FoodId = 7, QuantityGrams = 15 },

                // 17: Shrimp & Veggie Skewers
                new MealContent { MealId = 17, FoodId = 36, QuantityGrams = 150 },
                new MealContent { MealId = 17, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 17, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 17, FoodId = 12, QuantityGrams = 5 },
                new MealContent { MealId = 17, FoodId = 6, QuantityGrams = 150 },

                // 18: Pork Loin & Sweet Potato
                new MealContent { MealId = 18, FoodId = 37, QuantityGrams = 150 },
                new MealContent { MealId = 18, FoodId = 11, QuantityGrams = 200 },
                new MealContent { MealId = 18, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 18, FoodId = 12, QuantityGrams = 10 },

                // 19: Whole Wheat Pasta Primavera
                new MealContent { MealId = 19, FoodId = 38, QuantityGrams = 180 },
                new MealContent { MealId = 19, FoodId = 5, QuantityGrams = 80 },
                new MealContent { MealId = 19, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 19, FoodId = 12, QuantityGrams = 10 },

                // 20: Hummus & Veggies
                new MealContent { MealId = 20, FoodId = 39, QuantityGrams = 80 },
                new MealContent { MealId = 20, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 20, FoodId = 26, QuantityGrams = 80 },
                new MealContent { MealId = 20, FoodId = 23, QuantityGrams = 40 },

                // 21: Walnut & Spinach Salad
                new MealContent { MealId = 21, FoodId = 40, QuantityGrams = 30 },
                new MealContent { MealId = 21, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 21, FoodId = 21, QuantityGrams = 50 },
                new MealContent { MealId = 21, FoodId = 16, QuantityGrams = 50 },
                new MealContent { MealId = 21, FoodId = 12, QuantityGrams = 10 },

                // 22: Pumpkin Seed Oatmeal
                new MealContent { MealId = 22, FoodId = 13, QuantityGrams = 50 },
                new MealContent { MealId = 22, FoodId = 41, QuantityGrams = 15 },
                new MealContent { MealId = 22, FoodId = 50, QuantityGrams = 10 },
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
                new MealContent { MealId = 25, FoodId = 21, QuantityGrams = 50 },
                new MealContent { MealId = 25, FoodId = 16, QuantityGrams = 50 },
                new MealContent { MealId = 25, FoodId = 12, QuantityGrams = 10 },

                // 26: Sardine Toast
                new MealContent { MealId = 26, FoodId = 45, QuantityGrams = 90 },
                new MealContent { MealId = 26, FoodId = 23, QuantityGrams = 60 },
                new MealContent { MealId = 26, FoodId = 17, QuantityGrams = 50 },

                // 27: Oat Milk Protein Shake
                new MealContent { MealId = 27, FoodId = 46, QuantityGrams = 300 },
                new MealContent { MealId = 27, FoodId = 28, QuantityGrams = 20 },
                new MealContent { MealId = 27, FoodId = 2, QuantityGrams = 100 },

                // 28: Cauliflower Fried Rice (Vegan)
                new MealContent { MealId = 28, FoodId = 47, QuantityGrams = 200 },
                new MealContent { MealId = 28, FoodId = 34, QuantityGrams = 100 },
                new MealContent { MealId = 28, FoodId = 35, QuantityGrams = 50 },
                new MealContent { MealId = 28, FoodId = 12, QuantityGrams = 10 },

                // 29: Corn & Black Bean Salad
                new MealContent { MealId = 29, FoodId = 48, QuantityGrams = 120 },
                new MealContent { MealId = 29, FoodId = 33, QuantityGrams = 100 },
                new MealContent { MealId = 29, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 29, FoodId = 21, QuantityGrams = 50 },
                new MealContent { MealId = 29, FoodId = 12, QuantityGrams = 10 },

                // 30: Dark Chocolate & Almonds
                new MealContent { MealId = 30, FoodId = 49, QuantityGrams = 30 },
                new MealContent { MealId = 30, FoodId = 7, QuantityGrams = 20 },

                // 31: Chia Pudding with Berries
                new MealContent { MealId = 31, FoodId = 50, QuantityGrams = 30 },
                new MealContent { MealId = 31, FoodId = 29, QuantityGrams = 200 },
                new MealContent { MealId = 31, FoodId = 30, QuantityGrams = 50 },
                new MealContent { MealId = 31, FoodId = 27, QuantityGrams = 10 },

                // 32: Grilled Beef & Veggies
                new MealContent { MealId = 32, FoodId = 18, QuantityGrams = 180 },
                new MealContent { MealId = 32, FoodId = 11, QuantityGrams = 200 },
                new MealContent { MealId = 32, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 32, FoodId = 12, QuantityGrams = 10 }
            );
        }
    }
}
