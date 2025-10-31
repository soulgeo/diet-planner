using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DietPlanner.Models
{
    [Table("Meals")]
    public class Meal
    {
        [Key]
        [Column("meal_id")]
        public int MealId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [Column("meal_type")]
        public MealType MealType { get; set; }

        public virtual ICollection<MealContent> MealContents { get; set; } = new List<MealContent>();
        public override string ToString()
        {
            return Name;
        }
    }
}
