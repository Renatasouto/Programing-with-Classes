using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Activity running = new Running
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 45,
            Distance = 3.0
        };
        activities.Add(running);

        Activity cycling = new Cycling
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Speed = 6.0
        };
        activities.Add(cycling);

        Activity swimming = new Swimming
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 35,
            Laps = 30
        };
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}