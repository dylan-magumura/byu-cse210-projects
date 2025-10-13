using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            Cycling cycle = new Cycling(new DateTime(2022, 11, 3), 30, 15.0);
            Swimming swim = new Swimming(new DateTime(2022, 11, 3), 30, 20);

            List<Activity> activities = new List<Activity> { run, cycle, swim };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
