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
                new MealContent { MealId = 1, FoodId = 7, QuantityGrams = 20 }, // Increased
                new MealContent { MealId = 1, FoodId = 29, QuantityGrams = 200 },

                // MealId = 2: Chicken & Quinoa Lunch
                new MealContent { MealId = 2, FoodId = 3, QuantityGrams = 200 },
                new MealContent { MealId = 2, FoodId = 19, QuantityGrams = 200 },
                new MealContent { MealId = 2, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 2, FoodId = 51, QuantityGrams = 30 },
                new MealContent { MealId = 2, FoodId = 12, QuantityGrams = 10 }, // Added

                // MealId = 3: Salmon & Sweet Potato Dinner
                new MealContent { MealId = 3, FoodId = 4, QuantityGrams = 180 },
                new MealContent { MealId = 3, FoodId = 11, QuantityGrams = 250 },
                new MealContent { MealId = 3, FoodId = 10, QuantityGrams = 150 },
                new MealContent { MealId = 3, FoodId = 52, QuantityGrams = 5 },
                new MealContent { MealId = 3, FoodId = 12, QuantityGrams = 10 }, // Added

                // MealId = 4: Yogurt with Honey & Nuts
                new MealContent { MealId = 4, FoodId = 8, QuantityGrams = 200 },
                new MealContent { MealId = 4, FoodId = 27, QuantityGrams = 15 },
                new MealContent { MealId = 4, FoodId = 7, QuantityGrams = 25 }, // Increased

                // MealId = 5: Spinach Omelette
                new MealContent { MealId = 5, FoodId = 9, QuantityGrams = 180 },
                new MealContent { MealId = 5, FoodId = 10, QuantityGrams = 70 },
                new MealContent { MealId = 5, FoodId = 12, QuantityGrams = 5 }, // Added

                // MealId = 6: Tuna Salad
                new MealContent { MealId = 6, FoodId = 15, QuantityGrams = 150 },
                new MealContent { MealId = 6, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 6, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 6, FoodId = 54, QuantityGrams = 100 },
                new MealContent { MealId = 6, FoodId = 21, QuantityGrams = 30 }, // Added

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
                new MealContent { MealId = 34, FoodId = 12, QuantityGrams = 10 }, // Added
                new MealContent { MealId = 34, FoodId = 21, QuantityGrams = 30 }, // Added

                // Meal 35: Steamed Salmon & Broccoli (Dinner)
                new MealContent { MealId = 35, FoodId = 4, QuantityGrams = 180 },
                new MealContent { MealId = 35, FoodId = 5, QuantityGrams = 250 },
                new MealContent { MealId = 35, FoodId = 12, QuantityGrams = 10 }, // Added

                // Meal 36: Hummus on Wholemeal Bread (MorningSnack)
                new MealContent { MealId = 36, FoodId = 39, QuantityGrams = 40 },
                new MealContent { MealId = 36, FoodId = 23, QuantityGrams = 40 },

                // Meal 37: Greek Yogurt with Berries (AfternoonSnack)
                new MealContent { MealId = 37, FoodId = 31, QuantityGrams = 150 },
                new MealContent { MealId = 37, FoodId = 20, QuantityGrams = 50 },
                new MealContent { MealId = 37, FoodId = 30, QuantityGrams = 50 },

                // Meal 38: Chicken and Vegetable Stir-fry (Dinner)
                new MealContent { MealId = 38, FoodId = 3, QuantityGrams = 180 },
                new MealContent { MealId = 38, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 38, FoodId = 53, QuantityGrams = 50 },
                new MealContent { MealId = 38, FoodId = 26, QuantityGrams = 50 },
                new MealContent { MealId = 38, FoodId = 51, QuantityGrams = 30 },
                new MealContent { MealId = 38, FoodId = 12, QuantityGrams = 15 }, // Increased

                // Meal 39: Hearty Beef and Vegetable Stew (Dinner)
                new MealContent { MealId = 39, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 39, FoodId = 55, QuantityGrams = 200 },
                new MealContent { MealId = 39, FoodId = 53, QuantityGrams = 100 },
                new MealContent { MealId = 39, FoodId = 51, QuantityGrams = 50 },
                new MealContent { MealId = 39, FoodId = 52, QuantityGrams = 5 },

                // Meal 40: Scrambled Eggs with Spinach and Toast (Breakfast)
                new MealContent { MealId = 40, FoodId = 9, QuantityGrams = 180 },
                new MealContent { MealId = 40, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 40, FoodId = 23, QuantityGrams = 60 },
                new MealContent { MealId = 40, FoodId = 12, QuantityGrams = 5 }, // Added

                // Meal 41: Quinoa Salad with Chickpeas and Veggies (Lunch)
                new MealContent { MealId = 41, FoodId = 19, QuantityGrams = 150 },
                new MealContent { MealId = 41, FoodId = 25, QuantityGrams = 100 },
                new MealContent { MealId = 41, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 41, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 41, FoodId = 54, QuantityGrams = 50 },
                new MealContent { MealId = 41, FoodId = 12, QuantityGrams = 10 }, // Added

                // Meal 42: Turkey Meatballs with Whole Wheat Pasta (Dinner)
                new MealContent { MealId = 42, FoodId = 24, QuantityGrams = 180 },
                new MealContent { MealId = 42, FoodId = 38, QuantityGrams = 200 },
                new MealContent { MealId = 42, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 42, FoodId = 51, QuantityGrams = 30 },
                new MealContent { MealId = 42, FoodId = 52, QuantityGrams = 5 },
                new MealContent { MealId = 42, FoodId = 12, QuantityGrams = 10 }, // Added

                // Meal 43: Apple Slices with Peanut Butter (AfternoonSnack)
                new MealContent { MealId = 43, FoodId = 1, QuantityGrams = 150 },
                new MealContent { MealId = 43, FoodId = 28, QuantityGrams = 20 },

                // Meal 44: Hard-Boiled Eggs (MorningSnack)
                new MealContent { MealId = 44, FoodId = 9, QuantityGrams = 120 },

                // Meal 45: Chicken Salad Sandwich (Lunch)
                new MealContent { MealId = 45, FoodId = 3, QuantityGrams = 120 },
                new MealContent { MealId = 45, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 45, FoodId = 54, QuantityGrams = 30 },
                new MealContent { MealId = 45, FoodId = 8, QuantityGrams = 30 },
                new MealContent { MealId = 45, FoodId = 21, QuantityGrams = 30 }, // Added

                // Meal 46: Baked Salmon with Roasted Potatoes and Carrots (Dinner)
                new MealContent { MealId = 46, FoodId = 4, QuantityGrams = 150 },
                new MealContent { MealId = 46, FoodId = 55, QuantityGrams = 250 },
                new MealContent { MealId = 46, FoodId = 53, QuantityGrams = 150 },
                new MealContent { MealId = 46, FoodId = 12, QuantityGrams = 10 }, // Added

                // Meal 47: Overnight Oats with Berries (Breakfast)
                new MealContent { MealId = 47, FoodId = 13, QuantityGrams = 80 },
                new MealContent { MealId = 47, FoodId = 29, QuantityGrams = 200 },
                new MealContent { MealId = 47, FoodId = 50, QuantityGrams = 15 },
                new MealContent { MealId = 47, FoodId = 20, QuantityGrams = 50 },
                new MealContent { MealId = 47, FoodId = 30, QuantityGrams = 50 },
                new MealContent { MealId = 47, FoodId = 40, QuantityGrams = 15 }, // Added

                // Meal 48: Simple Chicken and Rice (Lunch)
                new MealContent { MealId = 48, FoodId = 3, QuantityGrams = 200 },
                new MealContent { MealId = 48, FoodId = 6, QuantityGrams = 250 },
                new MealContent { MealId = 48, FoodId = 12, QuantityGrams = 10 }, // Added

                // Meal 49: Tofu Scramble
                new MealContent { MealId = 49, FoodId = 34, QuantityGrams = 200 },
                new MealContent { MealId = 49, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 49, FoodId = 51, QuantityGrams = 30 },
                new MealContent { MealId = 49, FoodId = 26, QuantityGrams = 50 },

                // Meal 50: Cottage Cheese with Pear and Almonds
                new MealContent { MealId = 50, FoodId = 22, QuantityGrams = 150 },
                new MealContent { MealId = 50, FoodId = 42, QuantityGrams = 150 },
                new MealContent { MealId = 50, FoodId = 7, QuantityGrams = 20 },

                // Meal 51: Egg White Omelette with Turkey and Spinach
                new MealContent { MealId = 51, FoodId = 9, QuantityGrams = 200 }, // Using whole eggs as proxy for egg whites
                new MealContent { MealId = 51, FoodId = 24, QuantityGrams = 100 },
                new MealContent { MealId = 51, FoodId = 10, QuantityGrams = 70 },

                // Meal 52: Breakfast Burrito
                new MealContent { MealId = 52, FoodId = 9, QuantityGrams = 120 },
                new MealContent { MealId = 52, FoodId = 33, QuantityGrams = 50 },
                new MealContent { MealId = 52, FoodId = 26, QuantityGrams = 40 },
                new MealContent { MealId = 52, FoodId = 23, QuantityGrams = 50 }, // Using bread as proxy for tortilla

                // Meal 53: Smoked Salmon on Wholemeal Bread
                new MealContent { MealId = 53, FoodId = 4, QuantityGrams = 100 }, // Using salmon as proxy for smoked salmon
                new MealContent { MealId = 53, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 53, FoodId = 8, QuantityGrams = 20 }, // Using yogurt as proxy for cream cheese

                // Meal 54: Quinoa Porridge with Berries
                new MealContent { MealId = 54, FoodId = 19, QuantityGrams = 80 },
                new MealContent { MealId = 54, FoodId = 29, QuantityGrams = 150 },
                new MealContent { MealId = 54, FoodId = 20, QuantityGrams = 50 },
                new MealContent { MealId = 54, FoodId = 30, QuantityGrams = 50 },

                // Meal 55: Grilled Chicken Caesar Salad
                new MealContent { MealId = 55, FoodId = 3, QuantityGrams = 180 },
                new MealContent { MealId = 55, FoodId = 54, QuantityGrams = 150 },
                new MealContent { MealId = 55, FoodId = 8, QuantityGrams = 50 }, // Using yogurt as proxy for dressing
                new MealContent { MealId = 55, FoodId = 23, QuantityGrams = 30 }, // Croutons

                // Meal 56: Beef and Broccoli Stir-fry
                new MealContent { MealId = 56, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 56, FoodId = 5, QuantityGrams = 200 },
                new MealContent { MealId = 56, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 56, FoodId = 12, QuantityGrams = 10 }, // Added

                // Meal 57: Shrimp and Avocado Salad
                new MealContent { MealId = 57, FoodId = 36, QuantityGrams = 150 },
                new MealContent { MealId = 57, FoodId = 21, QuantityGrams = 50 },
                new MealContent { MealId = 57, FoodId = 54, QuantityGrams = 100 },
                new MealContent { MealId = 57, FoodId = 17, QuantityGrams = 50 },

                // Meal 58: Lentil and Vegetable Curry
                new MealContent { MealId = 58, FoodId = 14, QuantityGrams = 150 },
                new MealContent { MealId = 58, FoodId = 53, QuantityGrams = 100 },
                new MealContent { MealId = 58, FoodId = 10, QuantityGrams = 100 },
                new MealContent { MealId = 58, FoodId = 51, QuantityGrams = 50 },
                new MealContent { MealId = 58, FoodId = 6, QuantityGrams = 100 },

                // Meal 59: Tempeh Sandwich on Wholemeal Bread
                new MealContent { MealId = 59, FoodId = 44, QuantityGrams = 150 },
                new MealContent { MealId = 59, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 59, FoodId = 54, QuantityGrams = 30 },
                new MealContent { MealId = 59, FoodId = 17, QuantityGrams = 30 },

                // Meal 60: Greek Salad with Chicken
                new MealContent { MealId = 60, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 60, FoodId = 54, QuantityGrams = 100 },
                new MealContent { MealId = 60, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 60, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 60, FoodId = 26, QuantityGrams = 50 },

                // Meal 61: Stuffed Bell Peppers with Turkey and Quinoa
                new MealContent { MealId = 61, FoodId = 26, QuantityGrams = 200 }, // The pepper
                new MealContent { MealId = 61, FoodId = 24, QuantityGrams = 150 },
                new MealContent { MealId = 61, FoodId = 19, QuantityGrams = 100 },
                new MealContent { MealId = 61, FoodId = 51, QuantityGrams = 30 },

                // Meal 62: Black Bean Burgers
                new MealContent { MealId = 62, FoodId = 33, QuantityGrams = 200 },
                new MealContent { MealId = 62, FoodId = 23, QuantityGrams = 80 }, // The bun
                new MealContent { MealId = 62, FoodId = 54, QuantityGrams = 20 },
                new MealContent { MealId = 62, FoodId = 17, QuantityGrams = 20 },

                // Meal 63: Pork Chops with Apple and Sweet Potato
                new MealContent { MealId = 63, FoodId = 37, QuantityGrams = 180 },
                new MealContent { MealId = 63, FoodId = 1, QuantityGrams = 100 },
                new MealContent { MealId = 63, FoodId = 11, QuantityGrams = 200 },

                // Meal 64: Baked Shrimp with Broccoli
                new MealContent { MealId = 64, FoodId = 36, QuantityGrams = 200 },
                new MealContent { MealId = 64, FoodId = 5, QuantityGrams = 200 },
                new MealContent { MealId = 64, FoodId = 52, QuantityGrams = 5 },

                // Meal 65: Chicken and Black Bean Enchiladas
                new MealContent { MealId = 65, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 65, FoodId = 33, QuantityGrams = 100 },
                new MealContent { MealId = 65, FoodId = 17, QuantityGrams = 100 }, // Sauce
                new MealContent { MealId = 65, FoodId = 48, QuantityGrams = 50 }, // Corn

                // Meal 66: Vegan Lentil Shepherd's Pie
                new MealContent { MealId = 66, FoodId = 14, QuantityGrams = 200 }, // Lentil base
                new MealContent { MealId = 66, FoodId = 53, QuantityGrams = 100 },
                new MealContent { MealId = 66, FoodId = 51, QuantityGrams = 50 },
                new MealContent { MealId = 66, FoodId = 55, QuantityGrams = 250 }, // Potato topping

                // Meal 67: Pork and Apple Skewers
                new MealContent { MealId = 67, FoodId = 37, QuantityGrams = 180 },
                new MealContent { MealId = 67, FoodId = 1, QuantityGrams = 100 },
                new MealContent { MealId = 67, FoodId = 51, QuantityGrams = 50 },
                new MealContent { MealId = 67, FoodId = 26, QuantityGrams = 50 },

                // Meal 68: Lemon Herb Chicken with Roasted Potatoes
                new MealContent { MealId = 68, FoodId = 3, QuantityGrams = 200 },
                new MealContent { MealId = 68, FoodId = 55, QuantityGrams = 300 },
                new MealContent { MealId = 68, FoodId = 52, QuantityGrams = 5 },
                new MealContent { MealId = 68, FoodId = 12, QuantityGrams = 15 }, // Added

                // Meal 69: Spicy Shrimp with Cauliflower Rice
                new MealContent { MealId = 69, FoodId = 36, QuantityGrams = 180 },
                new MealContent { MealId = 69, FoodId = 47, QuantityGrams = 250 },
                new MealContent { MealId = 69, FoodId = 26, QuantityGrams = 30 }, // For spice

                // Meal 70: Beef and Carrot Stew
                new MealContent { MealId = 70, FoodId = 18, QuantityGrams = 180 },
                new MealContent { MealId = 70, FoodId = 53, QuantityGrams = 200 },
                new MealContent { MealId = 70, FoodId = 55, QuantityGrams = 150 },
                new MealContent { MealId = 70, FoodId = 51, QuantityGrams = 50 },

                // Meal 71: Cucumber Sticks with Hummus
                new MealContent { MealId = 71, FoodId = 16, QuantityGrams = 150 },
                new MealContent { MealId = 71, FoodId = 39, QuantityGrams = 50 },

                // Meal 72: A handful of Walnuts
                new MealContent { MealId = 72, FoodId = 40, QuantityGrams = 40 }, // Increased

                // Meal 73: Avocado on Wholemeal Bread
                new MealContent { MealId = 73, FoodId = 21, QuantityGrams = 70 }, // Increased
                new MealContent { MealId = 73, FoodId = 23, QuantityGrams = 60 },

                // Meal 74: Edamame Side
                new MealContent { MealId = 74, FoodId = 35, QuantityGrams = 100 },

                // Meal 75: A single Pear
                new MealContent { MealId = 75, FoodId = 42, QuantityGrams = 150 },

                // Meal 76: Cottage Cheese with Tomato
                new MealContent { MealId = 76, FoodId = 22, QuantityGrams = 150 },
                new MealContent { MealId = 76, FoodId = 17, QuantityGrams = 100 },

                // Meal 77: A small bowl of Blueberries
                new MealContent { MealId = 77, FoodId = 30, QuantityGrams = 100 },

                // Meal 78: Single Hard-boiled egg
                new MealContent { MealId = 78, FoodId = 9, QuantityGrams = 60 },

                // Revised 78 New Varied Meals
                // Low-Calorie / High-Protein
                new MealContent { MealId = 79, FoodId = 24, QuantityGrams = 150 },
                new MealContent { MealId = 79, FoodId = 16, QuantityGrams = 100 },
                new MealContent { MealId = 80, FoodId = 9, QuantityGrams = 250 }, // Egg whites - using whole egg as proxy
                new MealContent { MealId = 81, FoodId = 36, QuantityGrams = 200 },
                new MealContent { MealId = 81, FoodId = 26, QuantityGrams = 50 },
                new MealContent { MealId = 82, FoodId = 22, QuantityGrams = 200 },
                new MealContent { MealId = 83, FoodId = 4, QuantityGrams = 200 }, // Using Salmon as proxy for white fish
                new MealContent { MealId = 83, FoodId = 52, QuantityGrams = 5 },
                new MealContent { MealId = 84, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 85, FoodId = 31, QuantityGrams = 250 },
                new MealContent { MealId = 86, FoodId = 15, QuantityGrams = 150 },
                new MealContent { MealId = 87, FoodId = 36, QuantityGrams = 150 },
                new MealContent { MealId = 88, FoodId = 24, QuantityGrams = 80 }, // Turkey jerky
                new MealContent { MealId = 89, FoodId = 9, QuantityGrams = 180 },
                new MealContent { MealId = 89, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 90, FoodId = 4, QuantityGrams = 200 }, // Cod
                new MealContent { MealId = 90, FoodId = 5, QuantityGrams = 150 }, // Asparagus
                new MealContent { MealId = 91, FoodId = 24, QuantityGrams = 200 },
                new MealContent { MealId = 91, FoodId = 5, QuantityGrams = 150 },
                new MealContent { MealId = 92, FoodId = 29, QuantityGrams = 300 }, // Protein Water
                new MealContent { MealId = 93, FoodId = 36, QuantityGrams = 200 }, // Scallops
                new MealContent { MealId = 94, FoodId = 18, QuantityGrams = 200 }, // Bison
                new MealContent { MealId = 95, FoodId = 3, QuantityGrams = 200 }, // Rabbit
                new MealContent { MealId = 96, FoodId = 18, QuantityGrams = 200 }, // Venison
                new MealContent { MealId = 97, FoodId = 3, QuantityGrams = 200 }, // Partridge
                new MealContent { MealId = 97, FoodId = 53, QuantityGrams = 100 },
                new MealContent { MealId = 98, FoodId = 3, QuantityGrams = 200 }, // Pheasant
                new MealContent { MealId = 99, FoodId = 31, QuantityGrams = 150 }, // Halloumi
                new MealContent { MealId = 99, FoodId = 54, QuantityGrams = 100 },
                new MealContent { MealId = 100, FoodId = 4, QuantityGrams = 150 }, // Mackerel
                new MealContent { MealId = 101, FoodId = 4, QuantityGrams = 200 }, // Sea Bass
                new MealContent { MealId = 101, FoodId = 10, QuantityGrams = 100 },
                new MealContent { MealId = 102, FoodId = 22, QuantityGrams = 250 }, // Quark
                new MealContent { MealId = 102, FoodId = 30, QuantityGrams = 100 },

                // Balanced Meals
                new MealContent { MealId = 103, FoodId = 3, QuantityGrams = 180 },
                new MealContent { MealId = 103, FoodId = 6, QuantityGrams = 200 },
                new MealContent { MealId = 103, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 104, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 104, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 104, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 105, FoodId = 4, QuantityGrams = 180 }, // Cod
                new MealContent { MealId = 105, FoodId = 19, QuantityGrams = 150 },
                new MealContent { MealId = 105, FoodId = 5, QuantityGrams = 100 }, // Asparagus
                new MealContent { MealId = 106, FoodId = 37, QuantityGrams = 180 },
                new MealContent { MealId = 106, FoodId = 53, QuantityGrams = 200 },
                new MealContent { MealId = 107, FoodId = 24, QuantityGrams = 150 },
                new MealContent { MealId = 107, FoodId = 33, QuantityGrams = 100 },
                new MealContent { MealId = 107, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 108, FoodId = 38, QuantityGrams = 150 },
                new MealContent { MealId = 108, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 108, FoodId = 17, QuantityGrams = 100 },
                new MealContent { MealId = 109, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 109, FoodId = 55, QuantityGrams = 250 }, // Potato topping
                new MealContent { MealId = 110, FoodId = 4, QuantityGrams = 100 },
                new MealContent { MealId = 110, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 111, FoodId = 18, QuantityGrams = 100 },
                new MealContent { MealId = 111, FoodId = 14, QuantityGrams = 150 },
                new MealContent { MealId = 112, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 112, FoodId = 26, QuantityGrams = 100 },
                new MealContent { MealId = 112, FoodId = 19, QuantityGrams = 100 },
                new MealContent { MealId = 113, FoodId = 18, QuantityGrams = 180 },
                new MealContent { MealId = 113, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 114, FoodId = 18, QuantityGrams = 150 },
                new MealContent { MealId = 114, FoodId = 38, QuantityGrams = 200 },
                new MealContent { MealId = 115, FoodId = 3, QuantityGrams = 250 },
                new MealContent { MealId = 115, FoodId = 55, QuantityGrams = 300 },
                new MealContent { MealId = 116, FoodId = 18, QuantityGrams = 200 }, // Lamb
                new MealContent { MealId = 116, FoodId = 5, QuantityGrams = 100 },
                new MealContent { MealId = 117, FoodId = 3, QuantityGrams = 200 }, // Duck
                new MealContent { MealId = 117, FoodId = 1, QuantityGrams = 100 },
                new MealContent { MealId = 118, FoodId = 18, QuantityGrams = 150 }, // Moussaka
                new MealContent { MealId = 118, FoodId = 11, QuantityGrams = 200 },
                new MealContent { MealId = 119, FoodId = 4, QuantityGrams = 200 }, // Fish
                new MealContent { MealId = 119, FoodId = 55, QuantityGrams = 300 }, // Chips
                new MealContent { MealId = 120, FoodId = 3, QuantityGrams = 200 }, // Chicken Korma
                new MealContent { MealId = 120, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 120, FoodId = 8, QuantityGrams = 100 },
                new MealContent { MealId = 121, FoodId = 18, QuantityGrams = 200 }, // Beef Rendang
                new MealContent { MealId = 121, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 122, FoodId = 3, QuantityGrams = 100 }, // Paella
                new MealContent { MealId = 122, FoodId = 36, QuantityGrams = 100 },
                new MealContent { MealId = 122, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 123, FoodId = 3, QuantityGrams = 200 }, // Tikka Masala
                new MealContent { MealId = 123, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 123, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 124, FoodId = 3, QuantityGrams = 200 }, // Sweet and Sour
                new MealContent { MealId = 124, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 125, FoodId = 15, QuantityGrams = 150 }, // Tuna Pasta Bake
                new MealContent { MealId = 125, FoodId = 38, QuantityGrams = 200 },
                new MealContent { MealId = 126, FoodId = 37, QuantityGrams = 200 }, // Sausage
                new MealContent { MealId = 126, FoodId = 55, QuantityGrams = 300 }, // Mash

                // High-Calorie / High-Protein
                new MealContent { MealId = 127, FoodId = 18, QuantityGrams = 200 },
                new MealContent { MealId = 127, FoodId = 38, QuantityGrams = 250 },
                new MealContent { MealId = 128, FoodId = 4, QuantityGrams = 200 },
                new MealContent { MealId = 128, FoodId = 21, QuantityGrams = 80 },
                new MealContent { MealId = 128, FoodId = 7, QuantityGrams = 50 },
                new MealContent { MealId = 129, FoodId = 3, QuantityGrams = 250 }, // Chicken Thighs
                new MealContent { MealId = 129, FoodId = 11, QuantityGrams = 300 },
                new MealContent { MealId = 130, FoodId = 8, QuantityGrams = 250 },
                new MealContent { MealId = 130, FoodId = 32, QuantityGrams = 80 },
                new MealContent { MealId = 130, FoodId = 27, QuantityGrams = 30 },
                new MealContent { MealId = 131, FoodId = 18, QuantityGrams = 250 },
                new MealContent { MealId = 131, FoodId = 9, QuantityGrams = 180 },
                new MealContent { MealId = 132, FoodId = 18, QuantityGrams = 250 }, // Lamb Shoulder
                new MealContent { MealId = 132, FoodId = 53, QuantityGrams = 200 },
                new MealContent { MealId = 133, FoodId = 37, QuantityGrams = 250 }, // Pork Belly
                new MealContent { MealId = 133, FoodId = 14, QuantityGrams = 200 },
                new MealContent { MealId = 134, FoodId = 9, QuantityGrams = 200 },
                new MealContent { MealId = 134, FoodId = 37, QuantityGrams = 100 }, // Sausage
                new MealContent { MealId = 135, FoodId = 29, QuantityGrams = 400 }, // Gainer Shake
                new MealContent { MealId = 136, FoodId = 18, QuantityGrams = 250 },
                new MealContent { MealId = 136, FoodId = 23, QuantityGrams = 100 },
                new MealContent { MealId = 137, FoodId = 38, QuantityGrams = 250 },
                new MealContent { MealId = 137, FoodId = 18, QuantityGrams = 100 }, // Bacon
                new MealContent { MealId = 138, FoodId = 29, QuantityGrams = 200 },
                new MealContent { MealId = 138, FoodId = 28, QuantityGrams = 50 },
                new MealContent { MealId = 138, FoodId = 2, QuantityGrams = 100 },
                new MealContent { MealId = 139, FoodId = 18, QuantityGrams = 300 }, // Ribeye
                new MealContent { MealId = 139, FoodId = 10, QuantityGrams = 150 },
                new MealContent { MealId = 140, FoodId = 18, QuantityGrams = 200 }, // Lasagna
                new MealContent { MealId = 140, FoodId = 38, QuantityGrams = 150 },
                new MealContent { MealId = 141, FoodId = 38, QuantityGrams = 250 }, // Carbonara
                new MealContent { MealId = 141, FoodId = 9, QuantityGrams = 60 },
                new MealContent { MealId = 141, FoodId = 18, QuantityGrams = 80 }, // Bacon/Pancetta
                new MealContent { MealId = 142, FoodId = 18, QuantityGrams = 200 }, // Lamb Rogan Josh
                new MealContent { MealId = 142, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 143, FoodId = 37, QuantityGrams = 200 }, // Pulled Pork
                new MealContent { MealId = 143, FoodId = 23, QuantityGrams = 100 }, // Bap
                new MealContent { MealId = 144, FoodId = 18, QuantityGrams = 250 }, // Doner
                new MealContent { MealId = 144, FoodId = 23, QuantityGrams = 100 },
                new MealContent { MealId = 145, FoodId = 18, QuantityGrams = 150 }, // Mixed Grill
                new MealContent { MealId = 145, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 145, FoodId = 37, QuantityGrams = 100 },

                // Very-High-Calorie
                new MealContent { MealId = 146, FoodId = 38, QuantityGrams = 200 },
                new MealContent { MealId = 146, FoodId = 3, QuantityGrams = 150 },
                new MealContent { MealId = 146, FoodId = 7, QuantityGrams = 50 },
                new MealContent { MealId = 146, FoodId = 12, QuantityGrams = 20 },
                new MealContent { MealId = 147, FoodId = 18, QuantityGrams = 200 },
                new MealContent { MealId = 147, FoodId = 33, QuantityGrams = 150 },
                new MealContent { MealId = 147, FoodId = 6, QuantityGrams = 200 },
                new MealContent { MealId = 148, FoodId = 21, QuantityGrams = 100 },
                new MealContent { MealId = 148, FoodId = 4, QuantityGrams = 150 },
                new MealContent { MealId = 148, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 149, FoodId = 9, QuantityGrams = 120 }, // Full English
                new MealContent { MealId = 149, FoodId = 37, QuantityGrams = 100 },
                new MealContent { MealId = 149, FoodId = 18, QuantityGrams = 80 }, // Bacon
                new MealContent { MealId = 149, FoodId = 23, QuantityGrams = 80 },
                new MealContent { MealId = 150, FoodId = 23, QuantityGrams = 200 }, // Pizza base
                new MealContent { MealId = 150, FoodId = 17, QuantityGrams = 100 }, // Tomato sauce
                new MealContent { MealId = 150, FoodId = 18, QuantityGrams = 100 }, // Pepperoni
                new MealContent { MealId = 151, FoodId = 29, QuantityGrams = 300 }, // Gainer Shake
                new MealContent { MealId = 151, FoodId = 13, QuantityGrams = 100 },
                new MealContent { MealId = 151, FoodId = 28, QuantityGrams = 60 },
                new MealContent { MealId = 152, FoodId = 3, QuantityGrams = 150 }, // Jambalaya
                new MealContent { MealId = 152, FoodId = 37, QuantityGrams = 100 }, // Chorizo
                new MealContent { MealId = 152, FoodId = 6, QuantityGrams = 150 },
                new MealContent { MealId = 153, FoodId = 3, QuantityGrams = 250 }, // Tuscan Chicken
                new MealContent { MealId = 153, FoodId = 8, QuantityGrams = 100 }, // Cream
                new MealContent { MealId = 153, FoodId = 10, QuantityGrams = 50 },
                new MealContent { MealId = 154, FoodId = 23, QuantityGrams = 120 }, // Bagel
                new MealContent { MealId = 154, FoodId = 8, QuantityGrams = 80 }, // Cream Cheese
                new MealContent { MealId = 154, FoodId = 4, QuantityGrams = 100 }, // Smoked Salmon
                new MealContent { MealId = 155, FoodId = 37, QuantityGrams = 150 }, // Cassoulet
                new MealContent { MealId = 155, FoodId = 33, QuantityGrams = 200 }, // Beans
                new MealContent { MealId = 156, FoodId = 18, QuantityGrams = 150 }, // Feijoada
                new MealContent { MealId = 156, FoodId = 37, QuantityGrams = 100 },
                new MealContent { MealId = 156, FoodId = 33, QuantityGrams = 150 },

                // 40 New "Large" Meals (1.5x quantity of existing meals)
                // Breakfasts (10)
                // Meal 157: Oatmeal & Fruit Breakfast (Large) - based on MealId 1
                new MealContent { MealId = 157, FoodId = 13, QuantityGrams = 120 },
                new MealContent { MealId = 157, FoodId = 2, QuantityGrams = 150 },
                new MealContent { MealId = 157, FoodId = 7, QuantityGrams = 30 },
                new MealContent { MealId = 157, FoodId = 29, QuantityGrams = 300 },

                // Meal 158: Spinach Omelette (Large) - based on MealId 5
                new MealContent { MealId = 158, FoodId = 9, QuantityGrams = 270 },
                new MealContent { MealId = 158, FoodId = 10, QuantityGrams = 105 },
                new MealContent { MealId = 158, FoodId = 12, QuantityGrams = 7 },

                // Meal 159: Protein Smoothie (Large) - based on MealId 9
                new MealContent { MealId = 159, FoodId = 29, QuantityGrams = 375 },
                new MealContent { MealId = 159, FoodId = 8, QuantityGrams = 225 },
                new MealContent { MealId = 159, FoodId = 20, QuantityGrams = 150 },

                // Meal 160: Greek Yogurt Parfait (Large) - based on MealId 13
                new MealContent { MealId = 160, FoodId = 31, QuantityGrams = 300 },
                new MealContent { MealId = 160, FoodId = 30, QuantityGrams = 75 },
                new MealContent { MealId = 160, FoodId = 32, QuantityGrams = 75 },
                new MealContent { MealId = 160, FoodId = 27, QuantityGrams = 15 },

                // Meal 161: Scrambled Eggs with Spinach and Toast (Large) - based on MealId 40
                new MealContent { MealId = 161, FoodId = 9, QuantityGrams = 270 },
                new MealContent { MealId = 161, FoodId = 10, QuantityGrams = 75 },
                new MealContent { MealId = 161, FoodId = 23, QuantityGrams = 90 },
                new MealContent { MealId = 161, FoodId = 12, QuantityGrams = 7 },

                // Meal 162: Overnight Oats with Berries (Large) - based on MealId 47
                new MealContent { MealId = 162, FoodId = 13, QuantityGrams = 120 },
                new MealContent { MealId = 162, FoodId = 29, QuantityGrams = 300 },
                new MealContent { MealId = 162, FoodId = 50, QuantityGrams = 22 },
                new MealContent { MealId = 162, FoodId = 20, QuantityGrams = 75 },
                new MealContent { MealId = 162, FoodId = 30, QuantityGrams = 75 },
                new MealContent { MealId = 162, FoodId = 40, QuantityGrams = 22 },

                // Meal 163: Tofu Scramble (Large) - based on MealId 49
                new MealContent { MealId = 163, FoodId = 34, QuantityGrams = 300 },
                new MealContent { MealId = 163, FoodId = 10, QuantityGrams = 75 },
                new MealContent { MealId = 163, FoodId = 51, QuantityGrams = 45 },
                new MealContent { MealId = 163, FoodId = 26, QuantityGrams = 75 },

                // Meal 164: Breakfast Burrito (Large) - based on MealId 52
                new MealContent { MealId = 164, FoodId = 9, QuantityGrams = 180 },
                new MealContent { MealId = 164, FoodId = 33, QuantityGrams = 75 },
                new MealContent { MealId = 164, FoodId = 26, QuantityGrams = 60 },
                new MealContent { MealId = 164, FoodId = 23, QuantityGrams = 75 },

                // Meal 165: Full-Fat Yogurt with Granola and Honey (Large) - based on MealId 130
                new MealContent { MealId = 165, FoodId = 8, QuantityGrams = 375 },
                new MealContent { MealId = 165, FoodId = 32, QuantityGrams = 120 },
                new MealContent { MealId = 165, FoodId = 27, QuantityGrams = 45 },

                // Meal 166: Steak and Eggs (Large) - based on MealId 131
                new MealContent { MealId = 166, FoodId = 18, QuantityGrams = 375 },
                new MealContent { MealId = 166, FoodId = 9, QuantityGrams = 270 },

                // Lunches (15)
                // Meal 167: Chicken & Quinoa Lunch (Large) - based on MealId 2
                new MealContent { MealId = 167, FoodId = 3, QuantityGrams = 300 },
                new MealContent { MealId = 167, FoodId = 19, QuantityGrams = 300 },
                new MealContent { MealId = 167, FoodId = 26, QuantityGrams = 150 },
                new MealContent { MealId = 167, FoodId = 51, QuantityGrams = 45 },
                new MealContent { MealId = 167, FoodId = 12, QuantityGrams = 15 },

                // Meal 168: Tuna Salad (Large) - based on MealId 6
                new MealContent { MealId = 168, FoodId = 15, QuantityGrams = 225 },
                new MealContent { MealId = 168, FoodId = 17, QuantityGrams = 225 },
                new MealContent { MealId = 168, FoodId = 16, QuantityGrams = 150 },
                new MealContent { MealId = 168, FoodId = 54, QuantityGrams = 150 },
                new MealContent { MealId = 168, FoodId = 21, QuantityGrams = 45 },

                // Meal 169: Minced Meat with Rice (Large) - based on MealId 8
                new MealContent { MealId = 169, FoodId = 18, QuantityGrams = 225 },
                new MealContent { MealId = 169, FoodId = 6, QuantityGrams = 375 },
                new MealContent { MealId = 169, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 169, FoodId = 51, QuantityGrams = 75 },
                new MealContent { MealId = 169, FoodId = 53, QuantityGrams = 75 },

                // Meal 170: Lentil Soup (Large) - based on MealId 12
                new MealContent { MealId = 170, FoodId = 14, QuantityGrams = 450 },
                new MealContent { MealId = 170, FoodId = 51, QuantityGrams = 75 },
                new MealContent { MealId = 170, FoodId = 53, QuantityGrams = 75 },
                new MealContent { MealId = 170, FoodId = 52, QuantityGrams = 7 },

                // Meal 171: Black Bean Burrito Bowl (Large) - based on MealId 14
                new MealContent { MealId = 171, FoodId = 33, QuantityGrams = 300 },
                new MealContent { MealId = 171, FoodId = 19, QuantityGrams = 225 },
                new MealContent { MealId = 171, FoodId = 26, QuantityGrams = 75 },
                new MealContent { MealId = 171, FoodId = 16, QuantityGrams = 75 },

                // Meal 172: Whole Wheat Pasta Primavera (Large) - based on MealId 19
                new MealContent { MealId = 172, FoodId = 38, QuantityGrams = 330 },
                new MealContent { MealId = 172, FoodId = 5, QuantityGrams = 120 },
                new MealContent { MealId = 172, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 172, FoodId = 51, QuantityGrams = 45 },
                new MealContent { MealId = 172, FoodId = 52, QuantityGrams = 7 },

                // Meal 173: Lean Turkey Salad (Large) - based on MealId 34
                new MealContent { MealId = 173, FoodId = 24, QuantityGrams = 270 },
                new MealContent { MealId = 173, FoodId = 54, QuantityGrams = 150 },
                new MealContent { MealId = 173, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 173, FoodId = 16, QuantityGrams = 150 },
                new MealContent { MealId = 173, FoodId = 12, QuantityGrams = 15 },
                new MealContent { MealId = 173, FoodId = 21, QuantityGrams = 45 },

                // Meal 174: Quinoa Salad with Chickpeas and Veggies (Large) - based on MealId 41
                new MealContent { MealId = 174, FoodId = 19, QuantityGrams = 225 },
                new MealContent { MealId = 174, FoodId = 25, QuantityGrams = 150 },
                new MealContent { MealId = 174, FoodId = 16, QuantityGrams = 150 },
                new MealContent { MealId = 174, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 174, FoodId = 54, QuantityGrams = 75 },
                new MealContent { MealId = 174, FoodId = 12, QuantityGrams = 15 },

                // Meal 175: Chicken Salad Sandwich (Large) - based on MealId 45
                new MealContent { MealId = 175, FoodId = 3, QuantityGrams = 180 },
                new MealContent { MealId = 175, FoodId = 23, QuantityGrams = 120 },
                new MealContent { MealId = 175, FoodId = 54, QuantityGrams = 45 },
                new MealContent { MealId = 175, FoodId = 8, QuantityGrams = 45 },
                new MealContent { MealId = 175, FoodId = 21, QuantityGrams = 45 },

                // Meal 176: Simple Chicken and Rice (Large) - based on MealId 48
                new MealContent { MealId = 176, FoodId = 3, QuantityGrams = 300 },
                new MealContent { MealId = 176, FoodId = 6, QuantityGrams = 375 },
                new MealContent { MealId = 176, FoodId = 12, QuantityGrams = 15 },

                // Meal 177: Grilled Chicken Caesar Salad (Large) - based on MealId 55
                new MealContent { MealId = 177, FoodId = 3, QuantityGrams = 270 },
                new MealContent { MealId = 177, FoodId = 54, QuantityGrams = 225 },
                new MealContent { MealId = 177, FoodId = 8, QuantityGrams = 75 },
                new MealContent { MealId = 177, FoodId = 23, QuantityGrams = 45 },

                // Meal 178: Beef and Broccoli Stir-fry (Large) - based on MealId 56
                new MealContent { MealId = 178, FoodId = 18, QuantityGrams = 225 },
                new MealContent { MealId = 178, FoodId = 5, QuantityGrams = 300 },
                new MealContent { MealId = 178, FoodId = 6, QuantityGrams = 225 },
                new MealContent { MealId = 178, FoodId = 12, QuantityGrams = 15 },

                // Meal 179: Greek Salad with Chicken (Large) - based on MealId 60
                new MealContent { MealId = 179, FoodId = 3, QuantityGrams = 225 },
                new MealContent { MealId = 179, FoodId = 54, QuantityGrams = 150 },
                new MealContent { MealId = 179, FoodId = 16, QuantityGrams = 150 },
                new MealContent { MealId = 179, FoodId = 17, QuantityGrams = 150 },
                new MealContent { MealId = 179, FoodId = 26, QuantityGrams = 75 },

                // Meal 180: Chicken & Brown Rice Bowl (Large) - based on MealId 103
                new MealContent { MealId = 180, FoodId = 3, QuantityGrams = 270 },
                new MealContent { MealId = 180, FoodId = 6, QuantityGrams = 300 },
                new MealContent { MealId = 180, FoodId = 5, QuantityGrams = 150 },

                // Meal 181: Chicken Fajita Bowl (Large) - based on MealId 112
                new MealContent { MealId = 181, FoodId = 3, QuantityGrams = 225 },
                new MealContent { MealId = 181, FoodId = 26, QuantityGrams = 150 },
                new MealContent { MealId = 181, FoodId = 19, QuantityGrams = 150 },

                // Dinners (15)
                // Meal 182: Salmon & Sweet Potato Dinner (Large) - based on MealId 3
                new MealContent { MealId = 182, FoodId = 4, QuantityGrams = 270 },
                new MealContent { MealId = 182, FoodId = 11, QuantityGrams = 375 },
                new MealContent { MealId = 182, FoodId = 10, QuantityGrams = 225 },
                new MealContent { MealId = 182, FoodId = 52, QuantityGrams = 7 },
                new MealContent { MealId = 182, FoodId = 12, QuantityGrams = 15 },

                // Meal 183: Tofu Stir-Fry (Large) - based on MealId 15
                new MealContent { MealId = 183, FoodId = 34, QuantityGrams = 375 },
                new MealContent { MealId = 183, FoodId = 5, QuantityGrams = 150 },
                new MealContent { MealId = 183, FoodId = 47, QuantityGrams = 150 },
                new MealContent { MealId = 183, FoodId = 6, QuantityGrams = 300 },
                new MealContent { MealId = 183, FoodId = 51, QuantityGrams = 75 },

                // Meal 184: Pork Loin & Sweet Potato (Large) - based on MealId 18
                new MealContent { MealId = 184, FoodId = 37, QuantityGrams = 225 },
                new MealContent { MealId = 184, FoodId = 55, QuantityGrams = 375 },
                new MealContent { MealId = 184, FoodId = 10, QuantityGrams = 75 },

                // Meal 185: Grilled Beef & Veggies (Large) - based on MealId 32
                new MealContent { MealId = 185, FoodId = 18, QuantityGrams = 270 },
                new MealContent { MealId = 185, FoodId = 55, QuantityGrams = 375 },
                new MealContent { MealId = 185, FoodId = 5, QuantityGrams = 150 },
                new MealContent { MealId = 185, FoodId = 51, QuantityGrams = 75 },

                // Meal 186: Steamed Salmon & Broccoli (Large) - based on MealId 35
                new MealContent { MealId = 186, FoodId = 4, QuantityGrams = 270 },
                new MealContent { MealId = 186, FoodId = 5, QuantityGrams = 375 },
                new MealContent { MealId = 186, FoodId = 12, QuantityGrams = 15 },

                // Meal 187: Chicken and Vegetable Stir-fry (Large) - based on MealId 38
                new MealContent { MealId = 187, FoodId = 3, QuantityGrams = 270 },
                new MealContent { MealId = 187, FoodId = 5, QuantityGrams = 150 },
                new MealContent { MealId = 187, FoodId = 53, QuantityGrams = 75 },
                new MealContent { MealId = 187, FoodId = 26, QuantityGrams = 75 },
                new MealContent { MealId = 187, FoodId = 51, QuantityGrams = 45 },
                new MealContent { MealId = 187, FoodId = 12, QuantityGrams = 22 },

                // Meal 188: Hearty Beef and Vegetable Stew (Large) - based on MealId 39
                new MealContent { MealId = 188, FoodId = 18, QuantityGrams = 225 },
                new MealContent { MealId = 188, FoodId = 55, QuantityGrams = 300 },
                new MealContent { MealId = 188, FoodId = 53, QuantityGrams = 150 },
                new MealContent { MealId = 188, FoodId = 51, QuantityGrams = 75 },
                new MealContent { MealId = 188, FoodId = 52, QuantityGrams = 7 },

                // Meal 189: Turkey Meatballs with Whole Wheat Pasta (Large) - based on MealId 42
                new MealContent { MealId = 189, FoodId = 24, QuantityGrams = 270 },
                new MealContent { MealId = 189, FoodId = 38, QuantityGrams = 300 },
                new MealContent { MealId = 189, FoodId = 17, QuantityGrams = 225 },
                new MealContent { MealId = 189, FoodId = 51, QuantityGrams = 45 },
                new MealContent { MealId = 189, FoodId = 52, QuantityGrams = 7 },
                new MealContent { MealId = 189, FoodId = 12, QuantityGrams = 15 },

                // Meal 190: Baked Salmon with Roasted Potatoes and Carrots (Large) - based on MealId 46
                new MealContent { MealId = 190, FoodId = 4, QuantityGrams = 225 },
                new MealContent { MealId = 190, FoodId = 55, QuantityGrams = 375 },
                new MealContent { MealId = 190, FoodId = 53, QuantityGrams = 225 },
                new MealContent { MealId = 190, FoodId = 12, QuantityGrams = 15 },

                // Meal 191: Stuffed Bell Peppers with Turkey and Quinoa (Large) - based on MealId 61
                new MealContent { MealId = 191, FoodId = 26, QuantityGrams = 300 },
                new MealContent { MealId = 191, FoodId = 24, QuantityGrams = 225 },
                new MealContent { MealId = 191, FoodId = 19, QuantityGrams = 150 },
                new MealContent { MealId = 191, FoodId = 51, QuantityGrams = 45 },

                // Meal 192: Lemon Herb Chicken with Roasted Potatoes (Large) - based on MealId 68
                new MealContent { MealId = 192, FoodId = 3, QuantityGrams = 300 },
                new MealContent { MealId = 192, FoodId = 55, QuantityGrams = 450 },
                new MealContent { MealId = 192, FoodId = 52, QuantityGrams = 7 },
                new MealContent { MealId = 192, FoodId = 12, QuantityGrams = 22 },

                // Meal 193: Beef and Carrot Stew (Large) - based on MealId 70
                new MealContent { MealId = 193, FoodId = 18, QuantityGrams = 270 },
                new MealContent { MealId = 193, FoodId = 53, QuantityGrams = 300 },
                new MealContent { MealId = 193, FoodId = 55, QuantityGrams = 225 },
                new MealContent { MealId = 193, FoodId = 51, QuantityGrams = 75 },

                // Meal 194: Beef Stir-fry with Mixed Veggies (Large) - based on MealId 104
                new MealContent { MealId = 194, FoodId = 18, QuantityGrams = 225 },
                new MealContent { MealId = 194, FoodId = 5, QuantityGrams = 150 },
                new MealContent { MealId = 194, FoodId = 26, QuantityGrams = 150 },

                // Meal 195: Spaghetti Bolognese (Large) - based on MealId 114
                new MealContent { MealId = 195, FoodId = 18, QuantityGrams = 225 },
                new MealContent { MealId = 195, FoodId = 38, QuantityGrams = 300 },

                // Meal 196: Roast Chicken with Potatoes (Large) - based on MealId 115
                new MealContent { MealId = 196, FoodId = 3, QuantityGrams = 375 },
                new MealContent { MealId = 196, FoodId = 55, QuantityGrams = 450 }
            );
        }
    }
}
