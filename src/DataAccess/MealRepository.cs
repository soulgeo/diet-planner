using System.Collections.Generic;
using System.Linq;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace DietPlanner.DataAccess
{
    public static class MealRepository
    {
        public static List<Meal> GetValidMeals(Patient patient)
        {
            using (var db = new DietContext())
            {
                var meals = db.Meals
                    .Include(m => m.MealContents)
                    .ThenInclude(mc => mc.Food)
                    .Where(m => !m.MealContents.Any(mc => patient.Allergies.Contains(mc.Food.Allergen)))
                    .Where(m => !m.MealContents.Any(mc => patient.LeastFavorites.Select(f => f.Name).Contains(mc.Food.Name)))
                    .ToList();
                // var meals = db.Meals.ToList();

                return meals;
            }
        }
    }
}
