using System;
using System.Collections;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // initialize variables
        bool quit = true;
        int duration = 0;
        DateTime startTime = DateTime.Now;

        // while loop to keep the program running until the user chooses to quit
        while (quit){

            // clear the console
            Console.Clear();

            // print the menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start rating activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            // get user input (menu choice)
            int userInput = int.Parse(Console.ReadLine());

            // call activities based on user input (menu choice)
            switch (userInput){
                // start breathing activity
                case 1:
                    // set the name and description
                    string name = "Breathing Activity";
                    string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    ActivityBreathing breathingActivity = new ActivityBreathing(name, description);
                    duration = int.Parse(Console.ReadLine());
                    Console.Clear();
                    breathingActivity.GetReady();
                    Console.WriteLine();
                    breathingActivity.SetDuration(duration);
                    // breathingActivity.PrintDuration(duration);
                    breathingActivity.RunActivity(duration);
                    breathingActivity.WellDone();
                    breathingActivity.CompletedActivity(name, duration);
                    breathingActivity.CountDown(4);
                    break;
                // start reflecting activity
                case 2:
                    // set the name and description
                    name = "Reflecting Activity";
                    description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ActivityReflecting reflectingActivity = new ActivityReflecting(name, description);
                    duration = int.Parse(Console.ReadLine());
                    reflectingActivity.GetReady();
                    reflectingActivity.SetDuration(duration);
                    // get random indexes
                    int promptIndex = reflectingActivity.getRandomPromptIndex();
                    int question1Index = reflectingActivity.getRandomQuestionIndex1();
                    int question2Index = reflectingActivity.getRandomQuestionIndex2(question1Index);
                    // get random prompt and questions
                    string prompt = reflectingActivity.getRandomPrompt(promptIndex);
                    string question1 = reflectingActivity.getRandomQuestion1(question1Index);
                    string question2 = reflectingActivity.getRandomQuestion2(question2Index);
                    // print prompt and questions
                    reflectingActivity.PrintPrompt(prompt);
                    reflectingActivity.PrintQuestions(question1, question2, duration);
                    reflectingActivity.WellDone();
                    reflectingActivity.CompletedActivity(name, duration);
                    reflectingActivity.CountDown(4);
                    break;
                // start listing activity
                case 3:
                    // set the name and description
                    name = "Listing Activity";
                    description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ActivityListing listingActivity = new ActivityListing(name, description);
                    duration = int.Parse(Console.ReadLine());
                    listingActivity.GetReady();
                    listingActivity.SetDuration(duration);
                    int listingIndex = listingActivity.randomPromptIndex();
                    string listingPrompt = listingActivity.randomPrompt(listingIndex);
                    listingActivity.PrintMenu(listingPrompt);
                    listingActivity.userResponses(DateTime.Now, duration);
                    int responseCount = listingActivity.countResponses();
                    listingActivity.printResponseCount(responseCount);
                    listingActivity.WellDone();
                    listingActivity.CompletedActivity(name, duration);
                    listingActivity.CountDown(4);
                    break;
                // quit
                case 4:
                // set the name and description
                    name = "Rating Activity";
                    description = "This activity will allow you to rate an area of your life on a scale of 1 to 10 and reflect on it.";
                    ActivityRating ratingActivity = new ActivityRating(name, description);
                    duration = int.Parse(Console.ReadLine());
                    ratingActivity.GetReady();
                    ratingActivity.SetDuration(duration);
                    int ratingIndex = ratingActivity.randomPromptIndex();
                    string ratingPrompt = ratingActivity.randomPrompt(ratingIndex);
                    int rating = ratingActivity.getRating(ratingPrompt);
                    ratingActivity.printReflection(rating, ratingPrompt);
                    ratingActivity.userReflection(startTime, duration);
                    ratingActivity.WellDone(); 
                    ratingActivity.CompletedActivity(name, duration);
                    ratingActivity.CountDown(4);
                    break;
                case 5:
                    Console.WriteLine("Goodbye");
                    Console.WriteLine();
                    quit = false;
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    Thread.Sleep(800);
                    break;

            }
        }
    }
}