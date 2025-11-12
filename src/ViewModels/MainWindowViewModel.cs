using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DietPlanner.DataAccess;
using DietPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace diet_planner.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string patientName = "";

    [ObservableProperty]
    private int age = 30;

    [ObservableProperty]
    private Gender selectedGender = Gender.Male;

    [ObservableProperty]
    private float weightKg = 70;

    [ObservableProperty]
    private float heightCm = 175;

    [ObservableProperty]
    private ActivityLevel selectedActivityLevel = ActivityLevel.ModeratelyActive;

    [ObservableProperty]
    private WeightGoal selectedWeightGoal = WeightGoal.Maintain;

    [ObservableProperty]
    private List<KeyValuePair<string, List<Meal>>> displayedMealsByDay = new();

    [ObservableProperty]
    private bool hasPlanSummary;

    [ObservableProperty]
    private double? patientTdee;

    [ObservableProperty]
    private double? targetDailyCalories;

    [ObservableProperty]
    private double? targetDailyProtein;

    [ObservableProperty]
    private double? targetDailyFat;

    [ObservableProperty]
    private double? targetDailyCarbs;

    [ObservableProperty]
    private double? bestPlanDailyCalories;

    [ObservableProperty]
    private double? bestPlanDailyProtein;

    [ObservableProperty]
    private double? bestPlanDailyFat;

    [ObservableProperty]
    private double? bestPlanDailyCarbs;

    [ObservableProperty]
    private bool hasBreakfast = true;

    [ObservableProperty]
    private bool hasMorningSnack = false;

    [ObservableProperty]
    private bool hasLunch = true;

    [ObservableProperty]
    private bool hasAfternoonSnack = false;

    [ObservableProperty]
    private bool hasDinner = true;

    [ObservableProperty]
    private int proteinPercent = 30;

    [ObservableProperty]
    private int fatPercent = 30;

    [ObservableProperty]
    private int carbsPercent = 40;

    [ObservableProperty]
    private bool isFishAllergy = false;

    [ObservableProperty]
    private bool isNutsAllergy = false;

    [ObservableProperty]
    private bool isDairyAllergy = false;

    [ObservableProperty]
    private bool isEggAllergy = false;

    [ObservableProperty]
    private bool isGlutenAllergy = false;

    [ObservableProperty]
    private List<Food> availableFoods = new();

    [ObservableProperty]
    private Food? selectedFood;

    [ObservableProperty]
    private ObservableCollection<Food> selectedLeastFavorites = new();

    public bool HasMeals => DisplayedMealsByDay.Count > 0;

    partial void OnDisplayedMealsByDayChanged(List<KeyValuePair<string, List<Meal>>> value)
    {
        OnPropertyChanged(nameof(HasMeals));
    }

    public ObservableCollection<SelectionItem<WeightGoal>> WeightGoalItems { get; } =
        [
            new SelectionItem<WeightGoal>(WeightGoal.FastLoss, "Fast Loss (1.0 kg/week)"),
            new SelectionItem<WeightGoal>(WeightGoal.Loss, "Loss (0.5 kg/week)"),
            new SelectionItem<WeightGoal>(WeightGoal.MidLoss, "Mid Loss (0.25 kg/week)"),
            new SelectionItem<WeightGoal>(WeightGoal.Maintain, "Maintain (0.0 kg/week)"),
            new SelectionItem<WeightGoal>(WeightGoal.MidGain, "Mid Gain (0.25 kg/week)"),
            new SelectionItem<WeightGoal>(WeightGoal.Gain, "Gain (0.5 kg/week)"),
            new SelectionItem<WeightGoal>(WeightGoal.FastGain, "Fast Gain (1.0 kg/week)")
        ];

    public ObservableCollection<SelectionItem<ActivityLevel>> ActivityLevelItems { get; } =
        [
            new SelectionItem<ActivityLevel>(ActivityLevel.Sedentary, "Sedentary (Little to no exercise)"),
            new SelectionItem<ActivityLevel>(ActivityLevel.LightlyActive, "Lightly Active (Exercise 1-3 time/week)"),
            new SelectionItem<ActivityLevel>(ActivityLevel.ModeratelyActive, "Moderately Active (Daily exercise or intense exercise 3-4 times/week )"),
            new SelectionItem<ActivityLevel>(ActivityLevel.VeryActive, "Very Active (Intense exercise 6-7 times/week)"),
            new SelectionItem<ActivityLevel>(ActivityLevel.SuperActive, "Super Active (Very intense exercise daily, or physical job)"),
        ];

    public Gender[] Genders => Enum.GetValues<Gender>();
    public ActivityLevel[] ActivityLevels => Enum.GetValues<ActivityLevel>();
    public WeightGoal[] WeightGoals => Enum.GetValues<WeightGoal>();

    public MainWindowViewModel()
    {
        LoadFoods();
    }

    private void LoadFoods()
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(appDataPath, "DietPlanner", "DietPlanner.db");

            var options = new DbContextOptionsBuilder<DietContext>()
                .UseSqlite($"Data Source={dbPath}")
                .Options;

            using var db = new DietContext(options);
            AvailableFoods = db.Foods.OrderBy(f => f.Name).ToList();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error loading foods: {ex.Message}");
            AvailableFoods = new List<Food>();
        }
    }

    [RelayCommand]
    private void AddLeastFavorite()
    {
        if (SelectedFood != null && !SelectedLeastFavorites.Any(f => f.FoodId == SelectedFood.FoodId))
        {
            SelectedLeastFavorites.Add(SelectedFood);
            SelectedFood = null;
        }
    }

    private List<MealType> GetSelectedMealTypes()
    {
        var mealTypes = new List<MealType>();
        if (HasBreakfast) mealTypes.Add(MealType.Breakfast);
        if (HasMorningSnack) mealTypes.Add(MealType.MorningSnack);
        if (HasLunch) mealTypes.Add(MealType.Lunch);
        if (HasAfternoonSnack) mealTypes.Add(MealType.AfternoonSnack);
        if (HasDinner) mealTypes.Add(MealType.Dinner);
        return mealTypes;
    }

    [RelayCommand]
    private void RemoveLeastFavorite(Food food)
    {
        var toRemove = SelectedLeastFavorites.FirstOrDefault(f => f.FoodId == food.FoodId);
        if (toRemove != null)
        {
            SelectedLeastFavorites.Remove(toRemove);
        }
    }

    private List<Allergen> GetSelectedAllergies()
    {
        var allergies = new List<Allergen>();
        if (IsFishAllergy) allergies.Add(Allergen.Fish);
        if (IsNutsAllergy) allergies.Add(Allergen.Nuts);
        if (IsDairyAllergy) allergies.Add(Allergen.Dairy);
        if (IsEggAllergy) allergies.Add(Allergen.Egg);
        if (IsGlutenAllergy) allergies.Add(Allergen.Gluten);
        return allergies;
    }

    [RelayCommand]
    private void GenerateMeals()
    {
        HasPlanSummary = false;
        PatientTdee = null;
        TargetDailyCalories = null;
        TargetDailyProtein = null;
        TargetDailyFat = null;
        TargetDailyCarbs = null;
        BestPlanDailyCalories = null;
        BestPlanDailyProtein = null;
        BestPlanDailyFat = null;
        BestPlanDailyCarbs = null;

        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(appDataPath, "DietPlanner", "DietPlanner.db");

            var options = new DbContextOptionsBuilder<DietContext>()
                .UseSqlite($"Data Source={dbPath}")
                .Options;

            using var db = new DietContext(options);

            var patient = new Patient
            {
                Name = PatientName,
                Age = Age,
                Gender = SelectedGender,
                WeightKg = WeightKg,
                HeightCm = HeightCm,
                ActivityLevel = SelectedActivityLevel,
                Allergies = GetSelectedAllergies(),
                LeastFavorites = SelectedLeastFavorites.ToList()
            };

            var planProperties = new PlanProperties(patient, ProteinPercent, FatPercent, CarbsPercent)
            {
                WeightGoal = SelectedWeightGoal,
                MealTypes = [.. GetSelectedMealTypes()]
            };

            var plan = new Plan(planProperties);
            var validMeals = MealRepository.GetValidMeals(patient, db);

            if (validMeals.Count == 0)
            {
                DisplayedMealsByDay = [];
                return;
            }

            const int populationSize = 15;
            const int generationLimit = 3000;

            var evolvedPopulation = Genetic.RunEvolution(populationSize, validMeals, planProperties, generationLimit);
            var bestPlan = evolvedPopulation.FirstOrDefault();

            if (bestPlan == null || bestPlan.Meals.Count == 0)
            {
                plan.AddRandomMeals(validMeals);
                bestPlan = plan.Meals.Count > 0 ? plan : null;
            }

            if (bestPlan == null)
            {
                DisplayedMealsByDay = [];
                return;
            }

            // Organize meals by day 
            var mealsByDay = new List<KeyValuePair<string, List<Meal>>>();
            var mealsPerDay = planProperties.MealTypes.Count;
            var daysOfWeek = Enum.GetValues<DayOfWeek>().OrderBy(d => d == DayOfWeek.Sunday).ToList();

            for (int dayIndex = 0; dayIndex < daysOfWeek.Count; dayIndex++)
            {
                var dayName = daysOfWeek[dayIndex].ToString();
                var startIndex = dayIndex * mealsPerDay;
                var dayMeals = bestPlan.Meals.Skip(startIndex).Take(mealsPerDay).ToList();

                if (dayMeals.Count > 0)
                {
                    mealsByDay.Add(new KeyValuePair<string, List<Meal>>(dayName, dayMeals));
                }
            }

            DisplayedMealsByDay = mealsByDay;

            double totalCalories = 0;
            double totalProtein = 0;
            double totalFat = 0;
            double totalCarbs = 0;

            foreach (var meal in bestPlan.Meals)
            {
                foreach (var mc in meal.MealContents)
                {
                    totalCalories += mc.Food.Calories / 100.0 * mc.QuantityGrams;
                    totalProtein += mc.Food.Protein / 100.0 * mc.QuantityGrams;
                    totalFat += mc.Food.Fat / 100.0 * mc.QuantityGrams;
                    totalCarbs += mc.Food.Carbs / 100.0 * mc.QuantityGrams;
                }
            }

            PatientTdee = Math.Round(patient.TDEE, 2);
            TargetDailyCalories = planProperties.DailyCalorieTarget;
            TargetDailyProtein = Math.Round(planProperties.TargetProteinG, 2);
            TargetDailyFat = Math.Round(planProperties.TargetFatG, 2);
            TargetDailyCarbs = Math.Round(planProperties.TargetCarbG, 2);

            const double daysInPlan = 7.0;

            BestPlanDailyCalories = Math.Round(totalCalories / daysInPlan, 2);
            BestPlanDailyProtein = Math.Round(totalProtein / daysInPlan, 2);
            BestPlanDailyFat = Math.Round(totalFat / daysInPlan, 2);
            BestPlanDailyCarbs = Math.Round(totalCarbs / daysInPlan, 2);

            HasPlanSummary = true;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error generating meals: {ex.Message}");
        }
    }
}
