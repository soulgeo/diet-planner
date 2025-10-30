using System;
using System.Linq;
using System.Collections.Generic;

namespace DietPlanner.Models
{

    public class Plan
    {
        public PlanProperties PlanProperties { get; }

        private readonly List<PlanDay> _planDays;
        public IReadOnlyList<PlanDay> PlanDays => _planDays.AsReadOnly();

        public List<Meal> Meals { get; set; }

        public Plan(PlanProperties planProperties)
        {
            this.PlanProperties = planProperties;
            Meals = new List<Meal>();
            _planDays = new List<PlanDay>();
            foreach (DayOfWeek d in Enum.GetValues(typeof(DayOfWeek)))
            {
                PlanDay planDay = new PlanDay(this);
                planDay.DayOfWeek = d;
                _planDays.Add(planDay);
            }
        }

        public void AddRandomMealsFromList(List<Meal> meals)
        {
            var random = new Random();
            var mealsByType = meals.GroupBy(m => m.MealType)
                                  .ToDictionary(g => g.Key, g => g.ToList());

            foreach (DayOfWeek d in Enum.GetValues(typeof(DayOfWeek)))
            {
                foreach (MealType mt in PlanProperties.MealTypes)
                {
                    if (mealsByType.TryGetValue(mt, out var matchingMeals) && matchingMeals.Any())
                    {
                        var randomMeal = matchingMeals[random.Next(matchingMeals.Count)];
                        Meals.Add(randomMeal);
                    }
                }
            }
        }
    }
}
