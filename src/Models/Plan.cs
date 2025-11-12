using System;
using System.Linq;
using System.Collections.Generic;

namespace DietPlanner.Models
{
    public class Plan(PlanProperties planProperties)
    {
        public PlanProperties PlanProperties { get; } = planProperties;
        public List<Meal> Meals { get; set; } = [];

        public void AddRandomMeals(List<Meal> meals)
        {
            var random = new Random();
            var mealsByType = meals.GroupBy(m => m.MealType)
                                  .ToDictionary(g => g.Key, g => g.ToList());

            foreach (DayOfWeek d in Enum.GetValues<DayOfWeek>())
            {
                foreach (MealType mt in PlanProperties.MealTypes)
                {
                    if (mealsByType.TryGetValue(mt, out var matchingMeals) && matchingMeals.Count != 0)
                    {
                        var randomMeal = matchingMeals[random.Next(matchingMeals.Count)];
                        Meals.Add(randomMeal);
                    }
                }
            }
        }
    }
}
