using System;
using System.Collections;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        // initialize variables
        int level;
        bool quit = false;
        string goalType;
        string name = "";
        string description = "";
        int points = 0;
        int bonusPoints = 0;
        int timesUntilBonus = 0;
        int completedGoals = 0;
        // getter/setter for points
        // points and level placeholders:
        level = 0;
        // new instances
        

        // new infotracker instance
        InfoTracker infoTracker = new InfoTracker();

        // while loop for quit
        while (quit == false){

        // print menu
        Console.WriteLine();
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Events");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        
        // user choice
        string userInput = Console.ReadLine();

        

        // switch case based on user choice
        switch (userInput){
            // create new goal
            case "1":
                List<Goal> goals = new List<Goal>();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                goalType = Console.ReadLine();
                switch (goalType){
                    // simple goal
                    case "1":
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        simpleGoal.CreateGoal();
                        string sname = simpleGoal.GetName();
                        string sdescription = simpleGoal.GetDescription();
                        int spoints = simpleGoal.GetBasePoints();
                        Console.WriteLine($"{sname} {sdescription} {spoints}");
                        SimpleGoal newSimpleGoal = new SimpleGoal(sname, sdescription, spoints);
                        infoTracker.AddGoals(newSimpleGoal);
                        Console.WriteLine();
                        break;
                    // eternal goal
                    case "2":
                        EternalGoal eternalGoal = new EternalGoal(name, description, points, 0);
                        eternalGoal.CreateGoal();
                        string ename = eternalGoal.GetName();
                        string edescription = eternalGoal.GetDescription();
                        int epoints = eternalGoal.GetBasePoints();
                        Console.WriteLine($"{ename} {edescription} {epoints}");
                        EternalGoal newEternalGoal = new EternalGoal(ename, edescription, epoints, 0);
                        infoTracker.AddGoals(newEternalGoal);
                        break;
                    // checklist goal
                    case "3":
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonusPoints, timesUntilBonus, completedGoals);
                        checklistGoal.CreateGoal();
                        string cname = checklistGoal.GetName();
                        string cdescription = checklistGoal.GetDescription();
                        int cpoints = checklistGoal.GetBasePoints();
                        int cbonusPoints = checklistGoal.GetBonusPoints();
                        timesUntilBonus = checklistGoal.GetTimesUntilBonus();
                        Console.WriteLine($"{cname} {cdescription} {cpoints} {cbonusPoints} {timesUntilBonus}");
                        ChecklistGoal newChecklistGoal = new ChecklistGoal(cname, cdescription, cpoints, cbonusPoints, timesUntilBonus, completedGoals);
                        infoTracker.AddGoals(newChecklistGoal);
                        break;
                    // default
                    default:
                        Console.Clear();
                        Console.WriteLine("invalid choice");
                        Thread.Sleep(800);
                        break;
                }
                break;
            // list goals
            case "2":
                Console.WriteLine("The goals are: ");
                infoTracker.PrintGoal();
                break;
            // save goals
            case "3":
                Console.Write("What is the filename for the goal file? ");
                string saveFileName = Console.ReadLine();
                infoTracker.SaveGoals(saveFileName);
                break;
            // load goals
            case "4":
                Console.Write("What is the filename for the goal file? ");
                string loadFileName = Console.ReadLine();
                infoTracker.LoadGoals(loadFileName);
                break;
            // record events
            case "5":
                goals = infoTracker.GetGoalsList();
                Console.WriteLine("Your goals are:");
                int x = 0;
                foreach (Goal goal in goals){
                    x++;
                    Console.WriteLine($"{x}. {goal.GetName()}");
                }
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine())-1;
                infoTracker.UpdateGoal(index);
                points = infoTracker.GetTotalPoints();
                Console.WriteLine($"You now have {infoTracker.GetTotalPoints()} points.");
                break;
            // quit
            case "6":
                Console.WriteLine("Goodbye");
                quit = true;
                break;
            // default
            default:
                Console.Clear();
                Console.WriteLine("invalid choice");
                Thread.Sleep(800);
                break;
            }
        }
    }
}