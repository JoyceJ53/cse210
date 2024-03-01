using System;
using System.Diagnostics.CodeAnalysis;

public class ActivityReflecting : Activity 
{
    private string _prompt = "";
    private string[] _prompts = {"Think of a time when you did something really difficult.", "Think of a time when you accomplished a goal.", "Think of a time when you made a positive impact.", "Think of a time when you changed a bad day into a good one.", "Think of a time when you fixed a mistake."};
    private string _question = "";
    private string[] _questions = {"How did you feel when it was complete?", "What is your favorite thing about this experience?", "What did you learn about yourself through this experience?", "How can this experience help you in the future?", "What was the most challenging part of this experience?"};
    private Random _random = new Random();

    public ActivityReflecting(string name, string description) : base(name, description)
    {
        
    }
    public void PrintPrompt(string _prompt){
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"  --- {_prompt} ---  ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
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
    public void PrintQuestions(string question1, string question2, int duration){
        Console.WriteLine($" > {question1} ");
        int countdowntime = duration / 2;
        CountDown(countdowntime);
        Console.WriteLine($" > {question2} ");
        CountDown(countdowntime);
    }
    public int getRandomPromptIndex(){
        int index = _random.Next(0, _prompts.Length);
        return index;
    }
    public int getRandomQuestionIndex1(){
        int index1 = _random.Next(0, _questions.Length);        return index1;
    }
    public int getRandomQuestionIndex2(int index1){
        int index2 = _random.Next(0, _questions.Length);
        while(index1 == index2){
            index2 = _random.Next(0, _questions.Length);
        }
        return index2;
    }

    public string getRandomPrompt(int index){
        string prompt = _prompts[index];
        return prompt; 
    } 
    public string getRandomQuestion1(int index1){
        string question1 = _questions[index1];
        return question1;
    }
    public string getRandomQuestion2(int index2){
        string question2 = _questions[index2];
        return question2;
    }

}