using System.Collections.Generic;

public class Meal
{
    public int MealID { get; set; }
    public string Name { get; set; } = "name";
    public MealType MealType { get; set; }
    public int CaloriesKcal { get; set; }
    public double ProteinG { get; set; }
    public double CarbG { get; set; }
    public double FatG { get; set; }
    public List<Food> Contents { get; set; }

    public Meal(MealType mealType)
    {
        Contents = new List<Food>();
        this.MealType = mealType;
    }
};

