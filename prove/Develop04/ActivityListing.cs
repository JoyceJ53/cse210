using System;

public class ActivityListing : Activity
{
    Random _random = new Random();

    // initiate variables
    private string[] _prompts = {"When have you felt the Holy Ghost this month?", "What was something challenging you have overcome this month?", "What are some things that you are grateful for?", "What are some things you can improve on this month?", "How have you blessed the lives of others this month?"};
    private string _prompt;
    public List<string> _responses = new List<string>();
    private int _responseCount = 0;
    DateTime startTime = DateTime.Now;

    public ActivityListing(string name, string description) : base(name, description)
    {
        
    }
    public void userResponses(DateTime startTime, int duration){
        while ((DateTime.Now - startTime).TotalSeconds < duration){
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        }
    }
    public int countResponses(){
        foreach (string response in _responses){
            _responseCount++;
        }
        return _responseCount;
    }
    public void printResponseCount(int responseCount){
        Console.WriteLine("You listed " + _responseCount + " items!");
    }
    public int randomPromptIndex(){
        int index = _random.Next(0, _prompts.Length);
        return index;
    }
    public string randomPrompt(int index){
        string prompt = _prompts[index];
        return prompt;
    }
    public void PrintMenu(string prompt){
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine("You may begin in:");
        Console.Write(5);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(4);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(3);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(2);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(1);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Clear();
    }
    public void listingActivity(){

    }
}