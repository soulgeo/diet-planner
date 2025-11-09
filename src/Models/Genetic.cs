using System;
using System.Linq;
using System.Collections.Generic;

namespace DietPlanner.Models
{
    public static class Genetic
    {
        private static readonly int calMult = 3;
        private static readonly int proteinMult = 1;
        private static readonly int fatMult = 1;
        private static readonly int carbMult = 1;
        private static readonly int varietyWeight = 10000;

        private static readonly Random random = new();

        /// <summary>
        /// Generates some amount of new Plans with given Properties.
        /// </summary>
        public static List<Plan> GeneratePlans(int amount, List<Meal> validMeals, PlanProperties planProperties)
        {
            List<Plan> population = [];
            for (int i = 0; i < amount; i++)
            {
                Plan plan = new(planProperties);
                plan.AddRandomMealsFromList(validMeals);
                population.Add(plan);
            }
            return population;
        }

        /// <summary>
        /// Returns the "Unfitness" score for a Plan, which shows how far away from the target the plan is.
        /// Unfitness is calculated based on distance from target calories and macros, summed with a penalty
        /// for lack of variety in Meals.
        /// </summary>
        public static double Unfitness(Plan plan)
        {
            double calories = 0, protein = 0, fat = 0, carb = 0;

            foreach (var meal in plan.Meals)
            {
                foreach (var mc in meal.MealContents)
                {
                    calories += mc.Food.Calories / 100.0 * mc.QuantityGrams;
                    protein += mc.Food.Protein / 100.0 * mc.QuantityGrams;
                    fat += mc.Food.Fat / 100.0 * mc.QuantityGrams;
                    carb += mc.Food.Carbs / 100.0 * mc.QuantityGrams;
                }
            }

            double calWeight = calMult * Math.Abs(calories - (plan.PlanProperties.DailyCalorieTarget * 7));
            double protWeight = proteinMult * Math.Abs(protein - (plan.PlanProperties.TargetProteinG * 7)) * 4;
            double fatWeight = fatMult * Math.Abs(fat - (plan.PlanProperties.TargetFatG * 7)) * 9;
            double carbWeight = carbMult * Math.Abs(carb - (plan.PlanProperties.TargetCarbG * 7)) * 4;

            double nutritionalUnfitness = calWeight + protWeight + fatWeight + carbWeight;

            int uniqueMealCount = plan.Meals.Distinct().Count();
            int totalMeals = plan.Meals.Count;
            double varietyRatio = (double)uniqueMealCount / totalMeals;

            // Penalize plans with low variety. The weight (20000) can be tuned.
            double varietyPenalty = (1 - varietyRatio) * varietyWeight;

            return nutritionalUnfitness + varietyPenalty;
        }

        /// <summary>
        /// Returns a pair of Plans from a population, favoring plans with low Unfitness score. The plans
        /// will be crossed over later.
        /// </summary>
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
            int maxTries = 10; // To avoid infinite loop if all plans are the same
            int tries = 0;
            do
            {
                second = SelectParent();
                tries++;
            } while (first.Meals.SequenceEqual(second.Meals) && tries < maxTries);

            return [first, second];
        }

        /// <summary>
        /// Creates two offspring Plans from a pair of plans. Each offspring inherits a meal from one of 
        /// the two parents with an equal probability.
        /// </summary>
        public static List<Plan> UniformCrossover(Plan a, Plan b)
        {
            if (a.Meals.Count != b.Meals.Count)
            {
                throw new ArgumentException("Plans must have the same number of meals");
            }

            int length = a.Meals.Count;
            Plan offspring1 = new(a.PlanProperties);
            Plan offspring2 = new(a.PlanProperties);

            offspring1.Meals = new List<Meal>(length);
            offspring2.Meals = new List<Meal>(length);

            for (int i = 0; i < length; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    offspring1.Meals.Add(a.Meals[i]);
                    offspring2.Meals.Add(b.Meals[i]);
                }
                else
                {
                    offspring1.Meals.Add(b.Meals[i]);
                    offspring2.Meals.Add(a.Meals[i]);
                }
            }

            return [offspring1, offspring2];
        }

        /// <summary>
        /// Replaces some random amount of Meals in a Plan (up to a maximum number) with other Meals chosen randomly.
        /// </summary>
        public static Plan Mutation(Plan plan, Dictionary<MealType, List<Meal>> mealsByType, int num = 2, float probability = 0.7f)
        {
            Plan mutatedPlan = new(plan.PlanProperties)
            {
                Meals = [.. plan.Meals]
            };
            for (int i = 0; i < num; i++)
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
            }
            return mutatedPlan;
        }

        /// <summary>
        /// Holds the main evolutionary loop. Starts by generating a random population of Plans and iterately improves
        /// it by selecting the least "Unfit" Plans to reproduce and create the next generation, with random mutations
        /// introducing variation.
        /// </summary>
        public static List<Plan> RunEvolution(int populationSize, List<Meal> validMeals, PlanProperties planProperties, int generationLimit = 100)
        {
            var mealsByType = validMeals.GroupBy(m => m.MealType)
                                  .ToDictionary(g => g.Key, g => g.ToList());
            var population = GeneratePlans(populationSize, validMeals, planProperties);
            for (int i = 0; i < generationLimit; i++)
            {
                population = [.. population.OrderBy(Unfitness)];
                if (Unfitness(population[0]) < 100)
                {
                    break;
                }
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
                    var offsprings = UniformCrossover(parents[0], parents[1]);
                    offsprings[0] = Mutation(offsprings[0], mealsByType, num: 4);
                    offsprings[1] = Mutation(offsprings[1], mealsByType, num: 4);
                    nextGeneration.AddRange(offsprings);
                }
                if (offspringCount % 2 != 0)
                {
                    var parents = SelectionPair(population);
                    var offsprings = UniformCrossover(parents[0], parents[1]);
                    nextGeneration.Add(Mutation(offsprings[0], mealsByType, num: 4));
                }
                population = nextGeneration;
            }
            population = [.. population.OrderBy(Unfitness)];
            return population;
        }
    }
}
