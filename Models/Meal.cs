using System.Collections.Generic;

public class Meal
{
    public int MealID { get; set; }
    public string Name { get; set; } = "name";
    public MealType MealType { get; set; }
    public int Calories { get; set; }
    public double Protein { get; set; }
    public double Carbs { get; set; }
    public double Fat { get; set; }
    public List<Food>? Contents { get; set; }

    public Meal(MealType mealType)
    {
        this.MealType = mealType;
    }
};

