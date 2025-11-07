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
                WeightGoal = WeightGoal.MidLoss
            };
            int generations = 1000;

            // Act
            var randomPlans = Genetic.GeneratePlans(plansToGenerate, validMeals, properties);
            var population = Genetic.RunEvolution(plansToGenerate, validMeals, properties, generations);
            population = [.. population.OrderBy(Genetic.Unfitness)];

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
            for (int i = 0; i < randomPlans.Count; i++)
            {
                Console.WriteLine($"Plan {i + 1} (Unfitness: {Genetic.Unfitness(randomPlans[i])})");
            }
            Console.WriteLine("");
            for (int i = 0; i < population.Count; i++)
            {
                Console.WriteLine($"Plan {i + 1} (Unfitness: {Genetic.Unfitness(population[i])})");
            }

            var bestPlan = population[0];
            var mealIds = bestPlan.Meals.Select(m => m.MealId).ToList();
            List<Food> foods = FoodRepository.GetFoodsForMeals(mealIds);

            int calories = foods.Sum(f => f.Calories);
            double protein = foods.Sum(f => f.Protein);
            double fat = foods.Sum(f => f.Fat);
            double carb = foods.Sum(f => f.Carbs);

            Console.WriteLine("\nBest Plan Nutritional Information:");
            Console.WriteLine($"- Calories: {calories} kcal");
            Console.WriteLine($"- Protein: {protein:F2} g");
            Console.WriteLine($"- Fat: {fat:F2} g");
            Console.WriteLine($"- Carbs: {carb:F2} g");
        }
    }
}
