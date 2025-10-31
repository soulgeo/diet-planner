using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DietPlanner.Models
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        [Column("food_id")]
        public int FoodId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        // [Required]
        // [Column("food_category")]
        //  public string FoodCategory { get; set; } = null!;

        [Required]
        public int Calories { get; set; }

        [Required]
        public double Protein { get; set; }

        [Required]
        public double Carbs { get; set; }

        [Required]
        public double Fat { get; set; }

        public Allergen Allergen { get; set; }
    }
}
