using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class MealSeeder
    {
        public static void Seed(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal { MealId = 1, Name = "Πρωινό με Βρώμη & Φρούτα", MealType = MealType.Breakfast },
                new Meal { MealId = 2, Name = "Μεσημεριανό με Κοτόπουλο & Κινόα", MealType = MealType.Lunch },
                new Meal { MealId = 3, Name = "Βραδινό με Σολομό & Γλυκοπατάτα", MealType = MealType.Dinner },
                new Meal { MealId = 4, Name = "Γιαούρτι με Μέλι & Ξηρούς Καρπούς", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 5, Name = "Ομελέτα με Σπανάκι", MealType = MealType.Breakfast },
                new Meal { MealId = 6, Name = "Σαλάτα με Τόνο", MealType = MealType.Lunch },
                new Meal { MealId = 7, Name = "Τοστ με Γαλοπούλα & Αβοκάντο", MealType = MealType.MorningSnack },
                new Meal { MealId = 8, Name = "Κιμάς με Ρύζι", MealType = MealType.Lunch },
                new Meal { MealId = 9, Name = "Smoothie Πρωτεΐνης", MealType = MealType.Breakfast },
                new Meal { MealId = 10, Name = "Σαλάτα με Ρεβύθια", MealType = MealType.Dinner },
                new Meal { MealId = 11, Name = "Cottage με Φράουλες", MealType = MealType.AfternoonSnack },
                new Meal { MealId = 12, Name = "Φακές Σούπα", MealType = MealType.Lunch }
            );
        }
    }
}
