using System;

public class Plan
{
    public Patient patient { get; set; }
    public WeightGoal WeightGoal { get; set; }
    public double DailyCalorieTarget => ((float)WeightGoal / 100) * patient.TDEE;

    // Target macros
    public int ProteinPercent { get; }
    public int FatPercent { get; }
    public int CarbPercent { get; }

    public double TargetProteinG => (ProteinPercent / 100) * DailyCalorieTarget / 4;
    public double TargetFatG => (FatPercent / 100) * DailyCalorieTarget / 9;
    public double TargetCarbG => (CarbPercent / 100) * DailyCalorieTarget / 4;

    public Plan(Patient patient, int proteinPercent, int fatPercent, int carbPercent)
    {
        if (Math.Abs(proteinPercent + fatPercent + carbPercent - 100) > 0.001)
            throw new ArgumentException("Macro percentages must sum to 100");

        this.patient = patient;
        ProteinPercent = proteinPercent;
        FatPercent = fatPercent;
        CarbPercent = carbPercent;
    }
}
