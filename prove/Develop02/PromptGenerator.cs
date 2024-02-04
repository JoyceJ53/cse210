using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "Where did I see Jesus in my life today?",
        "What is one good thing that happened today?",
        "Who was one person I was kind to today and what did I do?",
        "What is one thing that I enjoyed doing today?",
        "What is one interesting thing that happened today?",
        "What is the weirdest thing that happened to me today?",
        "Who was the most interesting person I interacted with today?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}
