using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class MealFoodSeeder
    {
        public static void Seed(EntityTypeBuilder<MealFood> builder)
        {
            builder.HasData(
                // MealId = 1: Πρωινό με Βρώμη & Φρούτα
                new MealFood { MealId = 1, FoodId = 13, QuantityGrams = 50 },
                new MealFood { MealId = 1, FoodId = 2, QuantityGrams = 100 },
                new MealFood { MealId = 1, FoodId = 7, QuantityGrams = 15 },
                new MealFood { MealId = 1, FoodId = 29, QuantityGrams = 150 },

                // MealId = 2: Μεσημεριανό με Κοτόπουλο & Κινόα
                new MealFood { MealId = 2, FoodId = 3, QuantityGrams = 150 },
                new MealFood { MealId = 2, FoodId = 19, QuantityGrams = 180 },
                new MealFood { MealId = 2, FoodId = 26, QuantityGrams = 100 },
                new MealFood { MealId = 2, FoodId = 12, QuantityGrams = 10 },

                // MealId = 3: Βραδινό με Σολομό & Γλυκοπατάτα
                new MealFood { MealId = 3, FoodId = 4, QuantityGrams = 150 },
                new MealFood { MealId = 3, FoodId = 11, QuantityGrams = 200 },
                new MealFood { MealId = 3, FoodId = 10, QuantityGrams = 150 },

                // MealId = 4: Γιαούρτι με Μέλι & Ξηρούς Καρπούς
                new MealFood { MealId = 4, FoodId = 8, QuantityGrams = 200 },
                new MealFood { MealId = 4, FoodId = 27, QuantityGrams = 15 },
                new MealFood { MealId = 4, FoodId = 7, QuantityGrams = 20 },

                // MealId = 5: Ομελέτα με Σπανάκι
                new MealFood { MealId = 5, FoodId = 9, QuantityGrams = 120 },
                new MealFood { MealId = 5, FoodId = 10, QuantityGrams = 70 },
                new MealFood { MealId = 5, FoodId = 12, QuantityGrams = 5 },

                // MealId = 6: Σαλάτα με Τόνο
                new MealFood { MealId = 6, FoodId = 15, QuantityGrams = 100 },
                new MealFood { MealId = 6, FoodId = 17, QuantityGrams = 150 },
                new MealFood { MealId = 6, FoodId = 16, QuantityGrams = 100 },
                new MealFood { MealId = 6, FoodId = 12, QuantityGrams = 15 },

                // MealId = 7: Τοστ με Γαλοπούλα & Αβοκάντο
                new MealFood { MealId = 7, FoodId = 23, QuantityGrams = 70 },
                new MealFood { MealId = 7, FoodId = 24, QuantityGrams = 60 },
                new MealFood { MealId = 7, FoodId = 21, QuantityGrams = 50 },

                // MealId = 8: Κιμάς με Ρύζι
                new MealFood { MealId = 8, FoodId = 18, QuantityGrams = 150 },
                new MealFood { MealId = 8, FoodId = 6, QuantityGrams = 200 },
                new MealFood { MealId = 8, FoodId = 17, QuantityGrams = 100 },

                // MealId = 9: Smoothie Πρωτεΐνης
                new MealFood { MealId = 9, FoodId = 29, QuantityGrams = 250 },
                new MealFood { MealId = 9, FoodId = 8, QuantityGrams = 100 },
                new MealFood { MealId = 9, FoodId = 20, QuantityGrams = 50 },
                new MealFood { MealId = 9, FoodId = 28, QuantityGrams = 20 },

                // MealId = 10: Σαλάτα με Ρεβύθια
                new MealFood { MealId = 10, FoodId = 25, QuantityGrams = 150 },
                new MealFood { MealId = 10, FoodId = 16, QuantityGrams = 100 },
                new MealFood { MealId = 10, FoodId = 17, QuantityGrams = 100 },
                new MealFood { MealId = 10, FoodId = 26, QuantityGrams = 50 },
                new MealFood { MealId = 10, FoodId = 12, QuantityGrams = 20 },

                // MealId = 11: Cottage με Φράουλες
                new MealFood { MealId = 11, FoodId = 22, QuantityGrams = 150 },
                new MealFood { MealId = 11, FoodId = 20, QuantityGrams = 100 },
                new MealFood { MealId = 11, FoodId = 30, QuantityGrams = 50 },

                // MealId = 12: Φακές Σούπα
                new MealFood { MealId = 12, FoodId = 14, QuantityGrams = 250 },
                new MealFood { MealId = 12, FoodId = 12, QuantityGrams = 10 }
            );
        }
    }
}
