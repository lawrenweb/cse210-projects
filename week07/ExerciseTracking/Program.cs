using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("03 Nov 2022", 30, 3.0));
        activities.Add(new CyclingActivity("03 Nov 2022", 45, 12.0));
        activities.Add(new SwimmingActivity("03 Nov 2022", 40, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
