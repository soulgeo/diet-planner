public class Patient
{
    public string Name { get; set; } = "name";

    public int Age { get; set; }                        // Age in years
    public Gender Gender { get; set; }                  // Male or Female
    public float WeightKg { get; set; }                 // Weight in kg
    public float HeightCm { get; set; }                 // Height in cm
    public ActivityLevel ActivityLevel { get; set; }    // Activity level

    // Base Metabolic Rate (BMR)
    public double BMR => 10 * WeightKg + 6.25 * HeightCm - 5 * Age + 5 - (int)Gender * 166;

    // Total Daily Energy Expenditure (TDEE)
    public double TDEE => (1.2 + 0.175 * (float)ActivityLevel) * BMR;

}
