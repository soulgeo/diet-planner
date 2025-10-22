using System;

public class PlanProperties
{
    private int _minMealsPerDay = 3;
    private int _maxMealsPerDay = 6;

    private int _mealsPerDay;

    public Patient patient { get; set; }
    public WeightGoal WeightGoal { get; set; }

    // Target macros
    public int ProteinPercent { get; }
    public int FatPercent { get; }
    public int CarbPercent { get; }

    public double DailyCalorieTarget => ((float)WeightGoal / 100) * patient.TDEE;

    public double TargetProteinG => (ProteinPercent / 100) * DailyCalorieTarget / 4;
    public double TargetFatG => (FatPercent / 100) * DailyCalorieTarget / 9;
    public double TargetCarbG => (CarbPercent / 100) * DailyCalorieTarget / 4;

    public int MealsPerDay
    {
        get => _mealsPerDay;
        set
        {
            if (value < _minMealsPerDay || value > _maxMealsPerDay)
            {
                throw new ArgumentException("Meals per day must be between the allowed range.");
            }
            _mealsPerDay = value;
        }
    }

    public PlanProperties(Patient patient, int proteinPercent, int fatPercent, int carbPercent)
    {
        if (proteinPercent + fatPercent + carbPercent - 100 != 0)
            throw new ArgumentException("Macro percentages must sum to 100");

        this.patient = patient;
        ProteinPercent = proteinPercent;
        FatPercent = fatPercent;
        CarbPercent = carbPercent;
    }
}
