using DietPlanner.Models;
using DietPlanner.DataAccess;

namespace DietPlanner.Tests
{
    public class PlanTests
    {
        [Fact]
        public void AddRandomMealsFromList_Adds_Meals()
        {
            // Assign
            var patient = new Patient
            {
                Allergies = [Allergen.Nuts],
                LeastFavorites = [new Food { Name = "Tofu" }]
            };
            var plan = new Plan(new PlanProperties(patient, 30, 30, 40));

            // Act
            var validMeals = MealRepository.GetValidMeals(patient);
            plan.AddRandomMealsFromList(validMeals);

            // Assert
            Assert.DoesNotContain(validMeals, meal => meal.MealContents.Any(mc => mc.Food.Allergen == Allergen.Nuts));
            Assert.DoesNotContain(validMeals, meal => meal.MealContents.Any(mc => mc.Food.Name == "Tofu"));

            int i = 0;
            foreach (var meal in plan.Meals)
            {
                i++;
                Console.WriteLine($"Meal {i}: {meal.Name}, Type: {meal.MealType}");
            }
        }
    }
}
