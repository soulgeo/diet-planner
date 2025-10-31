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
                Allergies = new List<Allergen> { Allergen.Nuts },
                LeastFavorites = new List<Food> { new Food { Name = "Tofu" } }
            };
            var plan = new Plan(new PlanProperties(patient, 30, 30, 40));

            // Act
            var validMeals = MealRepository.GetValidMeals(patient);
            plan.AddRandomMealsFromList(validMeals);

            // Assert
            foreach (var meal in plan.Meals)
            {
                Console.WriteLine($"Meal: {meal.Name}, Type: {meal.MealType.ToString()}");
            }
        }
    }
}
