using System.Collections.Generic;
using System.Linq;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace DietPlanner.DataAccess
{
    public static class FoodRepository
    {
        public static List<Food> GetFoodsForMeals(List<int> mealIds)
        {
            using (var db = new DietContext())
            {
                var foods = db.MealContents
                              .Where(mc => mealIds.Contains(mc.MealId))
                              .Select(mc => mc.Food)
                              .AsNoTracking()
                              .ToList();
                return foods;
            }
        }
    }
}
