using System;

public class ActivityBreathing : Activity
{
    private string _breathIn = "Breath in...";
    private string _breathOut = "Now breath out...";
    private string _name = "";
    private string _description = "";

    public ActivityBreathing(string name, string description) : base(name, description)
    {

    }
    public void RunActivity(int duration){
        int[] waitTimes = new int[4];
        for (int i = 0; i < waitTimes.Length; i++){
            waitTimes[i] = duration / 8;
        }
        foreach (int seconds in waitTimes){
            Console.WriteLine();
            Console.Write(_breathIn);
            for (int second = 1; second <= seconds; second++){
            Console.Write($"{second}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write(_breathOut);
            for (int second = 1; second <= seconds; second++){
            Console.Write($"{second}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }

}