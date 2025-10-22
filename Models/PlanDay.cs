using System;
using System.Collections.Generic;
using System.Linq;

public class PlanDay
{
    public DayOfWeek DayOfWeek { get; set; }
    public Plan Plan { get; }

    private readonly List<Meal> _meals;
    public IReadOnlyList<Meal> Meals => _meals.AsReadOnly();

    public PlanDay(Plan plan, DayOfWeek dayOfWeek = default)
    {
        Plan = plan ?? throw new ArgumentNullException(nameof(plan));
        DayOfWeek = dayOfWeek;
        _meals = new List<Meal>();
    }

    public void AddMeal(Meal meal)
    {
        if (meal == null) throw new ArgumentNullException(nameof(meal));

        var allowedMealTypes = Plan?.PlanProperties?.MealTypes
            ?? throw new InvalidOperationException("Plan properties (MealTypes) are not initialized.");

        if (!allowedMealTypes.Contains(meal.MealType))
            throw new InvalidOperationException($"Meal type {meal.MealType} is not used by this plan.");

        if (_meals.Any(m => m.MealType == meal.MealType))
            throw new InvalidOperationException($"Meal of type {meal.MealType} is already included for this day.");

        _meals.Add(meal);
    }

    public bool RemoveMeal(MealType mealType)
    {
        var existing = _meals.FirstOrDefault(m => m.MealType == mealType);
        if (existing == null) return false;
        _meals.Remove(existing);
        return true;
    }
}

