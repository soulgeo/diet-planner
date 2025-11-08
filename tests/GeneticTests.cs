using DietPlanner.Models;
using DietPlanner.DataAccess;

namespace DietPlanner.Tests
{

    public class GeneticTests
    {
        [Fact]
        public void GeneratePlans_Generates_Plans()
        {
            // Assign
            var patient = new Patient
            {
                Allergies = [Allergen.Nuts],
                LeastFavorites = [new Food { Name = "Tofu" }]
            };

            var validMeals = MealRepository.GetValidMeals(patient);
            int plansToGenerate = 10;
            var properties = new PlanProperties(patient);

            // Act
            var population = Genetic.GeneratePlans(plansToGenerate, validMeals, properties);

            // Assert
            Assert.Equal(population.Count, plansToGenerate);
            foreach (var p in population)
            {
                Assert.NotEmpty(p.Meals);
            }

            // Console Output
            foreach (var p in population)
            {
                Console.WriteLine($"Plan {population.IndexOf(p) + 1} (Unfitness: {Genetic.Unfitness(p)}):");
                for (int i = 0; i < p.Meals.Count; i++)
                {
                    var m = p.Meals[i];
                    Console.WriteLine($"    Meal {i + 1}: {m.Name}, Type: {m.MealType}");
                }
            }
        }

        [Fact]
        public void Evolutionary_Loop()
        {
            // Assign
            var patient = new Patient
            {
                Age = 25,
                WeightKg = 80,
                HeightCm = 180,
                ActivityLevel = ActivityLevel.ModeratelyActive,
                Allergies = [Allergen.Nuts],
                LeastFavorites = [new Food { Name = "Tofu" }]
            };

            var validMeals = MealRepository.GetValidMeals(patient);
            int plansToGenerate = 10;
            var properties = new PlanProperties(patient)
            {
                WeightGoal = WeightGoal.MidLoss,
                MealTypes = [MealType.Breakfast, MealType.MorningSnack, MealType.Lunch, MealType.AfternoonSnack, MealType.Dinner]
            };
            int generations = 5000;

            // Act
            var randomPlans = Genetic.GeneratePlans(plansToGenerate, validMeals, properties);
            var population = Genetic.RunEvolution(plansToGenerate, validMeals, properties, generations);
            // population = [.. population.OrderBy(Genetic.Unfitness)];

            // Assert
            Assert.Equal(population.Count, plansToGenerate);
            foreach (var p in population)
            {
                Assert.NotEmpty(p.Meals);
            }

            // Console Output
            Console.WriteLine($"Patient's TDEE: {patient.TDEE} kcal");
            Console.WriteLine($"Target Daily Calories: {properties.DailyCalorieTarget} kcal");
            Console.WriteLine($"Target Daily Protein: {properties.TargetProteinG} grams");
            Console.WriteLine($"Target Daily Fat: {properties.TargetFatG} grams");
            Console.WriteLine($"Target Daily Carbs: {properties.TargetCarbG} grams");

            Console.WriteLine("Random population:");
            for (int i = 0; i < randomPlans.Count; i++)
            {
                Console.WriteLine($"Plan {i + 1} (Unfitness: {Genetic.Unfitness(randomPlans[i])})");
            }
            Console.WriteLine("Population after evolution:");
            for (int i = 0; i < population.Count; i++)
            {
                Console.WriteLine($"Plan {i + 1} (Unfitness: {Genetic.Unfitness(population[i])})");
            }

            var bestPlan = population[0];

            double calories = 0, protein = 0, fat = 0, carb = 0;

            foreach (var meal in bestPlan.Meals)
            {
                foreach (var mc in meal.MealContents)
                {
                    calories += (mc.Food.Calories / 100.0) * mc.QuantityGrams;
                    protein += (mc.Food.Protein / 100.0) * mc.QuantityGrams;
                    fat += (mc.Food.Fat / 100.0) * mc.QuantityGrams;
                    carb += (mc.Food.Carbs / 100.0) * mc.QuantityGrams;
                }
            }

            Console.WriteLine("\nBest Plan Nutritional Information (Average Daily):");
            Console.WriteLine($"- Calories: {calories / 7:F0} kcal");
            Console.WriteLine($"- Protein: {protein / 7:F2} g");
            Console.WriteLine($"- Fat: {fat / 7:F2} g");
            Console.WriteLine($"- Carbs: {carb / 7:F2} g");

            Console.WriteLine("\nBest Plan Meals:");
            int mealsPerDay = properties.MealTypes.Count;
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"--- Day {day + 1} ---");
                for (int mealIndex = 0; mealIndex < mealsPerDay; mealIndex++)
                {
                    int currentMealInList = (day * mealsPerDay) + mealIndex;
                    if (currentMealInList < bestPlan.Meals.Count)
                    {
                        var meal = bestPlan.Meals[currentMealInList];
                        Console.WriteLine($"  {meal.MealType}: {meal.Name}");
                    }
                }
            }
        }
    }
}
