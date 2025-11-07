using System;
using System.Linq;
using System.Collections.Generic;
using DietPlanner.DataAccess;

namespace DietPlanner.Models
{
    public static class Genetic
    {
        private static readonly Random random = new Random();

        public static List<Plan> GeneratePlans(int amount, List<Meal> validMeals, PlanProperties planProperties)
        {
            List<Plan> population = [];
            int i = 0;
            while (i < amount)
            {
                Plan plan = new(planProperties);
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

            return calWeight;
            // return calWeight + protWeight + fatWeight + carbWeight;
        }

        public static List<Plan> SelectionPair(List<Plan> population)
        {
            if (population.Count < 2)
                throw new ArgumentException("Population must contain at least 2 plans");

            const int tournamentSize = 2;

            Plan SelectParent()
            {
                var tournament = new List<Plan>();
                for (int i = 0; i < tournamentSize; i++)
                {
                    tournament.Add(population[random.Next(population.Count)]);
                }
                return tournament.OrderBy(Unfitness).First();
            }

            Plan first = SelectParent();
            Plan second;
            do
            {
                second = SelectParent();
            } while (second == first);

            return [first, second];
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
                return [a, b];
            }

            int p = random.Next(1, length);

            Plan offspring1 = new(a.PlanProperties);
            Plan offspring2 = new(a.PlanProperties);

            offspring1.Meals = [.. a.Meals.Take(p), .. b.Meals.Skip(p)];
            offspring2.Meals = [.. b.Meals.Take(p), .. a.Meals.Skip(p)];

            return [offspring1, offspring2];
        }

        public static Plan Mutation(Plan plan, Dictionary<MealType, List<Meal>> mealsByType, int num = 2, float probability = 0.7f)
        {
            Plan mutatedPlan = new(plan.PlanProperties)
            {
                Meals = [.. plan.Meals]
            };
            int i = 0;
            while (i < num)
            {
                if (random.NextDouble() > probability)
                {
                    continue;
                }
                int index = random.Next(plan.Meals.Count);
                if (mealsByType.TryGetValue(mutatedPlan.Meals[index].MealType, out var matchingMeals)
                        && matchingMeals.Count != 0)
                {
                    Meal randomMeal = matchingMeals[random.Next(matchingMeals.Count)];
                    mutatedPlan.Meals[index] = randomMeal;
                }
                i++;
            }
            return mutatedPlan;
        }

        public static List<Plan> RunEvolution(int populationSize, List<Meal> validMeals, PlanProperties planProperties, int generationLimit = 100)
        {
            var mealsByType = validMeals.GroupBy(m => m.MealType)
                                  .ToDictionary(g => g.Key, g => g.ToList());
            var population = GeneratePlans(populationSize, validMeals, planProperties);
            for (int i = 0; i < generationLimit; i++)
            {
                population = population.OrderBy(p => Unfitness(p)).ToList();
                var nextGeneration = new List<Plan>();

                var elite = new List<Plan>();
                if (population.Count > 0)
                {
                    elite.Add(population[0]);
                    var secondElite = population.Skip(1).FirstOrDefault(p => !p.Meals.SequenceEqual(population[0].Meals));
                    if (secondElite != null)
                    {
                        elite.Add(secondElite);
                    }
                    else if (population.Count > 1)
                    {
                        elite.Add(population[1]);
                    }
                }
                nextGeneration.AddRange(elite);

                int offspringCount = populationSize - nextGeneration.Count;
                for (int j = 0; j < offspringCount / 2; j++)
                {
                    var parents = SelectionPair(population);
                    var offsprings = SinglePointCrossover(parents[0], parents[1]);
                    offsprings[0] = Mutation(offsprings[0], mealsByType);
                    offsprings[1] = Mutation(offsprings[1], mealsByType);
                    nextGeneration.Add(offsprings[0]);
                    nextGeneration.Add(offsprings[1]);
                }
                if (offspringCount % 2 != 0)
                {
                    var parents = SelectionPair(population);
                    var offsprings = SinglePointCrossover(parents[0], parents[1]);
                    nextGeneration.Add(Mutation(offsprings[0], mealsByType));
                }
                population = nextGeneration;
            }
            return population;
        }
    }
}
