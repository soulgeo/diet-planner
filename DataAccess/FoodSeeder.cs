using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietPlanner.DataAccess
{
    public static class FoodSeeder
    {
        public static void Seed(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food { FoodId = 1, Name = "Μήλο", FoodCategory = "Φρούτο", Calories = 52, Protein = 0.3, Carbs = 14, Fat = 0.2, Allergens = "Κανένα" },
                new Food { FoodId = 2, Name = "Μπανάνα", FoodCategory = "Φρούτο", Calories = 89, Protein = 1.1, Carbs = 23, Fat = 0.3, Allergens = "Κανένα" },
                new Food { FoodId = 3, Name = "Στήθος Κοτόπουλο", FoodCategory = "Πρωτεΐνη", Calories = 165, Protein = 31, Carbs = 0, Fat = 3.6, Allergens = "Κανένα" },
                new Food { FoodId = 4, Name = "Σολομός", FoodCategory = "Πρωτεΐνη", Calories = 208, Protein = 20, Carbs = 0, Fat = 13, Allergens = "Ψάρι" },
                new Food { FoodId = 5, Name = "Μπρόκολο", FoodCategory = "Λαχανικό", Calories = 55, Protein = 3.7, Carbs = 11, Fat = 0.6, Allergens = "Κανένα" },
                new Food { FoodId = 6, Name = "Ρύζι καστανό", FoodCategory = "Υδατάνθρακας", Calories = 111, Protein = 2.6, Carbs = 23, Fat = 0.9, Allergens = "Κανένα" },
                new Food { FoodId = 7, Name = "Αμύγδαλα", FoodCategory = "Ξηροί Καρποί", Calories = 579, Protein = 21, Carbs = 22, Fat = 49, Allergens = "Ξηροί καρποί" },
                new Food { FoodId = 8, Name = "Γιαούρτι Στραγγιστό 2%", FoodCategory = "Γαλακτοκομικό", Calories = 73, Protein = 10, Carbs = 3.6, Fat = 2, Allergens = "Γαλακτοκομικά" },
                new Food { FoodId = 9, Name = "Αυγό", FoodCategory = "Πρωτεΐνη", Calories = 155, Protein = 13, Carbs = 1.1, Fat = 11, Allergens = "Αυγό" },
                new Food { FoodId = 10, Name = "Σπανάκι", FoodCategory = "Λαχανικό", Calories = 23, Protein = 2.9, Carbs = 3.6, Fat = 0.4, Allergens = "Κανένα" },
                new Food { FoodId = 11, Name = "Γλυκοπατάτα", FoodCategory = "Υδατάνθρακας", Calories = 86, Protein = 1.6, Carbs = 20, Fat = 0.1, Allergens = "Κανένα" },
                new Food { FoodId = 12, Name = "Ελαιόλαδο", FoodCategory = "Λιπαρά", Calories = 884, Protein = 0, Carbs = 0, Fat = 100, Allergens = "Κανένα" },
                new Food { FoodId = 13, Name = "Βρώμη", FoodCategory = "Υδατάνθρακας", Calories = 389, Protein = 16.9, Carbs = 66.3, Fat = 6.9, Allergens = "Γλουτένη" },
                new Food { FoodId = 14, Name = "Φακές", FoodCategory = "Όσπριο", Calories = 116, Protein = 9, Carbs = 20, Fat = 0.4, Allergens = "Κανένα" },
                new Food { FoodId = 15, Name = "Τόνος σε νερό", FoodCategory = "Πρωτεΐνη", Calories = 132, Protein = 28, Carbs = 0, Fat = 1.3, Allergens = "Ψάρι" },
                new Food { FoodId = 16, Name = "Αγγούρι", FoodCategory = "Λαχανικό", Calories = 15, Protein = 0.7, Carbs = 3.6, Fat = 0.1, Allergens = "Κανένα" },
                new Food { FoodId = 17, Name = "Ντομάτα", FoodCategory = "Λαχανικό", Calories = 18, Protein = 0.9, Carbs = 3.9, Fat = 0.2, Allergens = "Κανένα" },
                new Food { FoodId = 18, Name = "Μοσχαρίσιος Κιμάς (90/10)", FoodCategory = "Πρωτεΐνη", Calories = 217, Protein = 19, Carbs = 0, Fat = 15, Allergens = "Κανένα" },
                new Food { FoodId = 19, Name = "Κινόα", FoodCategory = "Υδατάνθρακας", Calories = 120, Protein = 4.4, Carbs = 21, Fat = 1.9, Allergens = "Κανένα" },
                new Food { FoodId = 20, Name = "Φράουλες", FoodCategory = "Φρούτο", Calories = 32, Protein = 0.7, Carbs = 7.7, Fat = 0.3, Allergens = "Κανένα" },
                new Food { FoodId = 21, Name = "Αβοκάντο", FoodCategory = "Λιπαρά", Calories = 160, Protein = 2, Carbs = 9, Fat = 15, Allergens = "Κανένα" },
                new Food { FoodId = 22, Name = "Τυρί Cottage", FoodCategory = "Γαλακτοκομικό", Calories = 98, Protein = 11, Carbs = 3.4, Fat = 4.3, Allergens = "Γαλακτοκομικά" },
                new Food { FoodId = 23, Name = "Ψωμί ολικής άλεσης", FoodCategory = "Υδατάνθρακας", Calories = 247, Protein = 13, Carbs = 41, Fat = 3.4, Allergens = "Γλουτένη" },
                new Food { FoodId = 24, Name = "Γαλοπούλα βραστή", FoodCategory = "Πρωτεΐνη", Calories = 135, Protein = 29, Carbs = 0, Fat = 1, Allergens = "Κανένα" },
                new Food { FoodId = 25, Name = "Ρεβύθια", FoodCategory = "Όσπριο", Calories = 164, Protein = 8.9, Carbs = 27, Fat = 2.6, Allergens = "Κανένα" },
                new Food { FoodId = 26, Name = "Πιπεριά Κόκκινη", FoodCategory = "Λαχανικό", Calories = 31, Protein = 1, Carbs = 6, Fat = 0.3, Allergens = "Κανένα" },
                new Food { FoodId = 27, Name = "Μέλι", FoodCategory = "Γλυκαντικό", Calories = 304, Protein = 0.3, Carbs = 82, Fat = 0, Allergens = "Κανένα" },
                new Food { FoodId = 28, Name = "Φυστικοβούτυρο", FoodCategory = "Λιπαρά", Calories = 588, Protein = 25, Carbs = 20, Fat = 50, Allergens = "Φιστίκια" },
                new Food { FoodId = 29, Name = "Γάλα 1.5%", FoodCategory = "Γαλακτοκομικό", Calories = 47, Protein = 3.4, Carbs = 5, Fat = 1.5, Allergens = "Γαλακτοκομικά" },
                new Food { FoodId = 30, Name = "Μύρτιλα (Blueberries)", FoodCategory = "Φρούτο", Calories = 57, Protein = 0.7, Carbs = 14, Fat = 0.3, Allergens = "Κανένα" }
            );
        }
    }
}
