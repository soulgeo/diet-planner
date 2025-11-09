using System.Collections.Generic;
using System.Linq;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace DietPlanner.DataAccess
{
    public static class FoodRepository
    {
        public static Dictionary<int, List<MealContent>> GetMealContentsForMeals(IEnumerable<int> mealIds)
        {
            using var db = new DietContext();
            var items = db.MealContents
                          .Where(mc => mealIds.Contains(mc.MealId))
                          .Include(mc => mc.Food)
                          .AsNoTracking()
                          .ToList();

            return items.GroupBy(mc => mc.MealId)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}
