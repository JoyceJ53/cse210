using System;

public class ChecklistGoal : Goal{

    private int _timesUntilBonus;
    private int _bonusPoints;
    private int _completedGoals;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesUntilBonus, int completedGoals) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _timesUntilBonus = timesUntilBonus;
        _completedGoals = completedGoals;
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
        if (_completedGoals >= _timesUntilBonus){
            return _points * _completedGoals + _bonusPoints;
        }
        else{
            return _points * _completedGoals;
        }
    }
    public int GetBonusPoints(){
        return _bonusPoints;
    }
    public int GetTimesUntilBonus(){
        return _timesUntilBonus;
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int timesUntilBonus = int.Parse(Console.ReadLine());
        _timesUntilBonus = timesUntilBonus;
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonusPoints = int.Parse(Console.ReadLine());
        _bonusPoints = bonusPoints;
    }
    public override void UpdateGoal(){
        _completedGoals++;
    }

    public override void PrintGoal(){
        if (_completedGoals >= _timesUntilBonus){
            Console.WriteLine($"[X] {_name} ({_description}) -- currently completed {_completedGoals}/{_timesUntilBonus}");
        }
        else{
            Console.WriteLine($"[ ] {_name} ({_description}) -- currently completed {_completedGoals}/{_timesUntilBonus}");
        }
    }
 
    public override string FileInfo(){
        // Console.Write(_points);
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_timesUntilBonus},{_completedGoals}";
    }

    public void printCompleted(int completedGoals, int totalGoals){
        Console.Write($"Completed: {completedGoals}/{totalGoals} ");
    }
}