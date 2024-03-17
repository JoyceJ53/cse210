using System;

public class SimpleGoal : Goal{
    private bool _completed = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points){
        
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
        if (_completed == true){
            return _points;
        }
        return 0;
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
    public override void UpdateGoal(){
        _completed = true;
    }

    public override string FileInfo()
    {
        return $"SimpleGoal:{_name},{_description},{_points}";
    }
    
    public override void PrintGoal(){
        if (_completed == true){
            Console.WriteLine($"[x] {_name} ({_description})");
        }
        else{
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

}