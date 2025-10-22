public class Plan
{
    public class Day
    {
        public Plan plan { get; }

        public Day(Plan plan)
        {
            this.plan = plan;
        }
    }

    public PlanProperties PlanProperties { get; }

    public Plan(PlanProperties planProperties)
    {
        this.PlanProperties = planProperties;
    }
}
