using System;
using System.Collections.Generic;

public class Plan
{
    public PlanProperties PlanProperties { get; }

    private readonly List<PlanDay> _planDays;
    public IReadOnlyList<PlanDay> PlanDays => _planDays.AsReadOnly();

    public Plan(PlanProperties planProperties)
    {
        this.PlanProperties = planProperties;
        _planDays = new List<PlanDay>();
        foreach (DayOfWeek d in Enum.GetValues(typeof(DayOfWeek)))
        {
            PlanDay planDay = new PlanDay(this);
            _planDays.Add(planDay);
        }
    }
}

