using System.Collections.Generic;

public record Meal
(
    int MealID,
    string Name,
    MealType MealType,
    int Calories,
    double Protein,
    double Carbs,
    double Fat,
    List<Food> Contents
);

