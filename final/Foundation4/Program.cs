using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        List<Activity> activities = new List<Activity>();

        // create activities' instances
        Running running = new Running(DateTime.Now, 30, 3.0);
        Cycling cycling = new Cycling(DateTime.Now, 30, 3.0);
        Swimming swimming = new Swimming(DateTime.Now, 20, 5);

        // add activities to list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // iterate through list
        foreach (Activity activity in activities){
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}