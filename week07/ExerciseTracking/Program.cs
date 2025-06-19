using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity run = new Running("16 Jun 2025", 30, 4.8);       // 4.8 km en 30 min
        Activity bike = new Cycling("16 Jun 2025", 45, 15.0);     // 15 kph durante 45 min
        Activity swim = new Swimming("16 Jun 2025", 60, 40);      // 40 largos (laps), 60 min

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        // Mostrar los resúmenes
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}