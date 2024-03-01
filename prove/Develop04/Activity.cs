using System;
using System.Runtime.CompilerServices;

public class Activity {

    // initialize variables
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    // activity method to set the name description and duration
    public Activity(string name, string description){

        // set the name, description, and duration
        _name = name;
        _description = description;

        // clear the console
        Console.Clear();
        // print the activity name and description
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
    }



    // get duration 
    public int GetDuration(){
        return _duration;
    }
    // set duration
    public void SetDuration(int duration){
        _duration = duration;
    }

    public void GetReady(){
        Console.WriteLine("Get ready...");
        CountDown(4);
    }
    public void WellDone(){
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
        CountDown(4);
    }


    // method to show a countdown
    public void CountDown(int duration)
    {
        // start time
        DateTime startTime = DateTime.Now;
        // add the duration to the start time to get future time
        DateTime futureTime = startTime.AddSeconds(duration);

        // while the current time is less than the future time display the spinner
        while (DateTime.Now < futureTime){
            // Console.WriteLine(currentTime);
            Spinner(true);
        }

    }

    public void CompletedActivity(string activityName, int duration){
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {activityName}.\n");
    }

    // method to show the spinner for a period of time based on the number passed into it
    public void Spinner (bool spinner){
        // write the first character
        Console.Write("-");
        // pause for 0.5 seconds
        Thread.Sleep(500);
        // erase the previous character
        Console.Write("\b \b");
        // write the second character
        Console.Write("\\");
        // pause for 0.5 seconds
        Thread.Sleep(500);
        // erase the previous character
        Console.Write("\b \b");
        // write the third character
        Console.Write("|");
        // pause for 0.5 seconds
        Thread.Sleep(500);
        // erase the previous character
        Console.Write("\b \b");
        // write the fourth character
        Console.Write("/");
        // pause for 0.5 seconds
        Thread.Sleep(500);
        // erase the previous character
        Console.Write("\b \b");
        
    }
}