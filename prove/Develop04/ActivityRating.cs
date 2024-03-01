using System;

public class ActivityRating : Activity
{
    private string[] _prompts = {"church calling", "scripture reading", "finances", "personal life", "personal relationships"};
    Random _random = new Random();
    
    public ActivityRating(string name, string description) : base(name, description)
    {

    }
    public int getRating(string prompt){
        Console.Clear();
        Console.WriteLine($"On a scale of 1 to 10, how would you rate yourself in your {prompt}?");
        int rating = int.Parse(Console.ReadLine());
        return rating;
    }
    public void printReflection(int rating, string prompt){
        if (rating >= 7){
            Console.WriteLine($"How can you continue to do well in your {prompt}?");
        }
        else{
            Console.WriteLine($"What can you do to improve in your {prompt}?");
        }
    }
    public void userReflection(DateTime startTime, int duration){
        while ((DateTime.Now - startTime).TotalSeconds < duration){
            Console.Write("> ");
            Console.ReadLine();
        }
    }
    public int randomPromptIndex(){
        int index = _random.Next(0, _prompts.Length);
        return index;
    }
    public string randomPrompt(int index){
        string prompt = _prompts[index];
        return prompt;
    }
}

        // Console.WriteLine("You may begin in:");
        // Console.Write(5);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(4);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(3);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(2);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(1);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Clear();