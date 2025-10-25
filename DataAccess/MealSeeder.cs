using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class MealSeeder
    {
        public static void Seed(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal { MealId = 1, Name = "Πρωινό με Βρώμη & Φρούτα", MealType = "Πρωινό" },
                new Meal { MealId = 2, Name = "Μεσημεριανό με Κοτόπουλο & Κινόα", MealType = "Μεσημεριανό" },
                new Meal { MealId = 3, Name = "Βραδινό με Σολομό & Γλυκοπατάτα", MealType = "Βραδινό" },
                new Meal { MealId = 4, Name = "Γιαούρτι με Μέλι & Ξηρούς Καρπούς", MealType = "Σνακ" },
                new Meal { MealId = 5, Name = "Ομελέτα με Σπανάκι", MealType = "Πρωινό" },
                new Meal { MealId = 6, Name = "Σαλάτα με Τόνο", MealType = "Μεσημεριανό" },
                new Meal { MealId = 7, Name = "Τοστ με Γαλοπούλα & Αβοκάντο", MealType = "Σνακ" },
                new Meal { MealId = 8, Name = "Κιμάς με Ρύζι", MealType = "Μεσημεριανό" },
                new Meal { MealId = 9, Name = "Smoothie Πρωτεΐνης", MealType = "Πρωινό" },
                new Meal { MealId = 10, Name = "Σαλάτα με Ρεβύθια", MealType = "Βραδινό" },
                new Meal { MealId = 11, Name = "Cottage με Φράουλες", MealType = "Σνακ" },
                new Meal { MealId = 12, Name = "Φακές Σούπα", MealType = "Μεσημεριανό" }
            );
        }
    }
}
