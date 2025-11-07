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
                new MealContent { MealId = 78, FoodId = 9, QuantityGrams = 60 }
            );
        }
    }
}
