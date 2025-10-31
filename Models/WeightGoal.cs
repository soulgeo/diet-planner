namespace DietPlanner.Models
{
    public enum WeightGoal : int
    {
        FastLoss = 63,      // 1 kg/week
        Loss = 82,          // 0.5 kg/week
        MidLoss = 91,       // 0.25 kg/week
        Maintain = 100,
        MidGain = 109,      // 0.25 kg/week
        Gain = 118,         // 0.5 kg/week
        FastGain = 137      // 1 kg/week
    }
}
