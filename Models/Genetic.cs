using System;
using System.Linq;
using System.Collections.Generic;
using DietPlanner.DataAccess;

namespace DietPlanner.Models
{
    public static class Genetic
    {
        public static List<Plan> GeneratePlans(int amount, List<Meal> validMeals, PlanProperties planProperties)
        {
            List<Plan> population = new List<Plan>();
            int i = 0;
            while (i < amount)
            {
                Plan plan = new Plan(planProperties);
                plan.AddRandomMealsFromList(validMeals);
                population.Add(plan);
                i++;
            }
            return population;
        }

        public static double Unfitness(Plan plan)
        {
            int calories = 0;
            double protein = 0, fat = 0, carb = 0;
            var mealIds = plan.Meals.Select(m => m.MealId).ToList();

            List<Food> foods = FoodRepository.GetFoodsForMeals(mealIds);
            foreach (var f in foods)
            {
                calories += f.Calories;
                protein += f.Protein;
                fat += f.Fat;
                carb += f.Carbs;
            }
            int calWeight = Math.Abs(calories - plan.PlanProperties.DailyCalorieTarget);
            double protWeight = Math.Abs(protein - plan.PlanProperties.TargetProteinG) * 4;
            double fatWeight = Math.Abs(fat - plan.PlanProperties.TargetFatG) * 9;
            double carbWeight = Math.Abs(carb - plan.PlanProperties.TargetCarbG) * 4;

            return calWeight + protWeight + fatWeight + carbWeight;
        }

        public static List<Plan> SelectionPair(List<Plan> population)
        {
            if (population.Count < 2)
                throw new ArgumentException("Population must contain at least 2 plans");

            Random rand = new Random();

            var weightedList = new List<Plan>();
            foreach (Plan plan in population)
            {
                int copies = Math.Max(1, (int)(100 / (Unfitness(plan) + 1)));
                for (int i = 0; i < copies; i++)
                {
                    weightedList.Add(plan);
                }
            }

            Plan first = weightedList[rand.Next(weightedList.Count)];
            Plan second;
            do
            {
                second = weightedList[rand.Next(weightedList.Count)];
            } while (second == first && population.Count > 1);

            return new List<Plan> { first, second };
        }

        public static List<Plan> SinglePointCrossover(Plan a, Plan b)
        {
            if (a.Meals.Count != b.Meals.Count)
            {
                throw new ArgumentException("Plans must have the same number of meals");
            }

            int length = a.Meals.Count;
            if (length < 2)
            {
                return new List<Plan> { a, b };
            }

            Random rand = new Random();
            int p = rand.Next(1, length);

            Plan offspring1 = new Plan(a.PlanProperties);
            Plan offspring2 = new Plan(a.PlanProperties);

            offspring1.Meals = a.Meals.Take(p).Concat(b.Meals.Skip(p)).ToList();
            offspring2.Meals = b.Meals.Take(p).Concat(a.Meals.Skip(p)).ToList();

            return new List<Plan> { offspring1, offspring2 };
        }

        public static Plan Mutation(Plan plan, List<Meal> validMeals, int num = 1, float probability = 0.5f)
        {
            // TODO: Add use for probability arguement.
            var rand = new Random();
            var mealsByType = validMeals.GroupBy(m => m.MealType)
                                  .ToDictionary(g => g.Key, g => g.ToList());

            int index = rand.Next(plan.Meals.Count);

            Plan mutatedPlan = plan;
            int i = 0;
            while (i < num)
            {
                if (mealsByType.TryGetValue(mutatedPlan.Meals[index].MealType, out var matchingMeals)
                        && matchingMeals.Any())
                {
                    var randomMeal = matchingMeals[rand.Next(matchingMeals.Count)];
                    mutatedPlan.Meals[index] = randomMeal;
                }
                i++;
            }
            return mutatedPlan;
        }
    }
}
