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

    [ObservableProperty]
    private double averageDailyCalories = 0;

    [ObservableProperty]
    private double averageDailyProtein = 0;

    [ObservableProperty]
    private double averageDailyFat = 0;

    [ObservableProperty]
    private double averageDailyCarbs = 0;

    public bool HasMeals => DisplayedMealsByDay.Count > 0;

    partial void OnDisplayedMealsByDayChanged(List<KeyValuePair<string, List<Meal>>> value)
    {
        OnPropertyChanged(nameof(HasMeals));
    }

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
            // clear selection so user can add the same item later if removed
            SelectedFood = null;
        }
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

            var planProperties = new PlanProperties(patient)
            {
                WeightGoal = SelectedWeightGoal
            };

            var plan = new Plan(planProperties);
            var validMeals = MealRepository.GetValidMeals(patient, db);
            plan.AddRandomMealsFromList(validMeals);

            // Organize meals by day 
            var mealsByDay = new List<KeyValuePair<string, List<Meal>>>();
            var mealsPerDay = planProperties.MealTypes.Count; 
            var daysOfWeek = Enum.GetValues<DayOfWeek>().ToList();
            
            for (int dayIndex = 0; dayIndex < daysOfWeek.Count; dayIndex++)
            {
               var dayName = $"Day{dayIndex + 1}";
                var startIndex = dayIndex * mealsPerDay;
                var dayMeals = plan.Meals.Skip(startIndex).Take(mealsPerDay).ToList();
                
                if (dayMeals.Count > 0)
                {
                    mealsByDay.Add(new KeyValuePair<string, List<Meal>>(dayName, dayMeals));
                }
            }

            DisplayedMealsByDay = mealsByDay;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error generating meals: {ex.Message}");
        }
    }
}
