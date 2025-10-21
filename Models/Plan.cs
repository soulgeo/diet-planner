public class Plan
{
    public Patient patient { get; set; }

    public WeightGoal WeightGoal { get; set; }
    public PlanType PlanType { get; set; }

    // Daily Calorie Target
    public double DailyCalorieTarget => ((float)WeightGoal / 100) * patient.TDEE;

    // Daily Macro Constraints
    public double MinProteinG => 1.2 * patient.WeightKg;
    public double MaxProteinG => 2.4 * patient.WeightKg;
    public double MinFatG => 0.2 * DailyCalorieTarget / 9;
    public double MaxFatG => 0.35 * DailyCalorieTarget / 9;
    public double MinCarbG => (DailyCalorieTarget - (MaxProteinG * 4 + MaxFatG * 9)) / 4;
    public double MaxCarbG => (DailyCalorieTarget - (MinProteinG * 4 + MinFatG * 9)) / 4;

    public double TargetProteinG => PlanType switch
    {
        PlanType.Balanced => (MinProteinG + MaxProteinG) / 2,
        PlanType.LowFat => 0,
        PlanType.LowCarb => 0,
        PlanType.HighProtein => MaxProteinG,
        _ => 0
    };
    public double TargetFatG => PlanType switch
    {
        PlanType.Balanced => (2 * MinFatG + MaxFatG) / 2,
        PlanType.LowFat => MinFatG,
        PlanType.LowCarb => 0,
        PlanType.HighProtein => 0,
        _ => 0
    };
    public double TargetCarbG => PlanType switch
    {
        PlanType.Balanced => (2 * MinCarbG + MaxCarbG) / 2,
        PlanType.LowFat => 0,
        PlanType.LowCarb => MinCarbG,
        PlanType.HighProtein => 0,
        _ => 0
    };

    public Plan(Patient patient)
    {
        this.patient = patient;
    }
}
