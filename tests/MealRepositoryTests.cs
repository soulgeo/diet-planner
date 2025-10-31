using DietPlanner.Models;
using DietPlanner.DataAccess;

namespace DietPlanner.Tests
{
    public class MealRepositoryTests
    {
        [Fact]
        public void GetValidMeals_Should_Exclude_Allergic_And_Disliked_Meals()
        {
            // Arrange
            var patient = new Patient
            {
                Allergies = new List<Allergen> { Allergen.Nuts },
                LeastFavorites = new List<Food> { new Food { Name = "Tofu" } }
            };

            // Act
            var validMeals = MealRepository.GetValidMeals(patient);

            // Assert
            Assert.DoesNotContain(validMeals, meal => meal.MealContents.Any(mc => mc.Food.Allergen == Allergen.Nuts));
            Assert.DoesNotContain(validMeals, meal => meal.MealContents.Any(mc => mc.Food.Name == "Tofu"));
        }
    }
}
