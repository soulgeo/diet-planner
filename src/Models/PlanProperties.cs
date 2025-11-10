using System;
using System.Collections.Generic;

namespace DietPlanner.Models
{
    public class PlanProperties
    {
        public Patient Patient { get; set; }
        public WeightGoal WeightGoal { get; set; }

        // Target macros
        public int ProteinPercent { get; }
        public int FatPercent { get; }
        public int CarbPercent { get; }

        public int DailyCalorieTarget => (int)Math.Round((float)WeightGoal / 100 * Patient.TDEE);

        public double TargetProteinG => ProteinPercent * 0.01 * DailyCalorieTarget / 4;
        public double TargetFatG => FatPercent * 0.01 * DailyCalorieTarget / 9;
        public double TargetCarbG => CarbPercent * 0.01 * DailyCalorieTarget / 4;

        public HashSet<MealType> MealTypes { get; set; }

        public PlanProperties(Patient patient,
                              int proteinPercent = 30,
                              int fatPercent = 30,
                              int carbPercent = 40)
        {
            if (proteinPercent + fatPercent + carbPercent - 100 != 0)
                throw new ArgumentException("Macro percentages must sum to 100");

            Patient = patient;
            MealTypes = [MealType.Breakfast, MealType.Lunch, MealType.Dinner];
            ProteinPercent = proteinPercent;
            FatPercent = fatPercent;
            CarbPercent = carbPercent;
        }
    }
}
