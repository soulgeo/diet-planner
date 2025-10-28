using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DietPlanner.Models
{
    [Table("Meal_Foods")]
    public class MealContent
    {
        [Column("meal_id")]
        public int MealId { get; set; }
        public Meal Meal { get; set; } = null!;

        [Column("food_id")]
        public int FoodId { get; set; }
        public Food Food { get; set; } = null!;

        [Required]
        [Column("quantity_grams")]
        public double QuantityGrams { get; set; }
    }
}
