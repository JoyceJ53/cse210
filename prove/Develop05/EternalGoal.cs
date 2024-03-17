using System;
using System.ComponentModel.DataAnnotations;

public class EternalGoal : Goal{
    private int _timesCompleted = 0;
    public EternalGoal(string name, string description, int points, int timesCompleted) : base(name, description, points){
        _timesCompleted = timesCompleted;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetBasePoints(){
        return _points;
    }
    public override int GetPoints(){
        return _points * _timesCompleted;
    }
    public override void CreateGoal(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        _name = name;
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        _description = description;
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _points = points;
    }
    public override string FileInfo(){
        return $"EternalGoal:{_name},{_description},{_points},{_timesCompleted}";
    }
    public override void UpdateGoal(){
        _timesCompleted++;

    }

    public override void PrintGoal(){
            Console.WriteLine($"[ ] {_name} ({_description})");

    }
    public void UpdateGoal(int accomplishedGoal){
        
    }


}