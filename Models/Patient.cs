public class Patient
{
    public string Name { get; set; } = "name";

    public int Age { get; set; }
    public Gender Gender { get; set; }
    public float WeightKg { get; set; }
    public float HeightCm { get; set; }
    public ActivityLevel ActivityLevel { get; set; }

    // Base Metabolic Rate (BMR)
    public double BMR => 10 * WeightKg + 6.25 * HeightCm - 5 * Age + 5 - (int)Gender * 166;

    // Total Daily Energy Expenditure (TDEE)
    public double TDEE => (1.2 + 0.175 * (float)ActivityLevel) * BMR;

}
