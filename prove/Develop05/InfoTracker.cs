using System;

public class InfoTracker{
    // new instances
    private List<Goal> _goals = new List<Goal>();
    Goal goal = new EternalGoal("test", "test", 0, 0);
    SimpleGoal simpleGoal = new SimpleGoal("test", "test", 0);
    // initialize variables
    private int _completedGoals;
    private int _totalGoals;

    public void AddGoals(Goal goal){
        _goals.Add(goal);
    }
    public List<Goal> GetGoalsList(){
        return _goals;
    }
    public void PrintGoal(){
        int index = 0;
        foreach (Goal goal in _goals){
            index++;
            Console.Write($"{index}. ");
            goal.PrintGoal();
        }
    }
    public void SaveGoals(string fileName){
        using (StreamWriter streamWriter = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                streamWriter.WriteLine(goal.FileInfo());
            }
        } 
    }
    public void LoadGoals(string fileName){
        if(File.Exists(fileName))
        {
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] splitLine = line.Split(":");
                    string goalType = splitLine[0];
                    string[] goalInfo = splitLine[1].Split(",");
                    switch (goalType){
                        case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]));
                        _goals.Add(simpleGoal);
                        break;
                        case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), int.Parse(goalInfo[3]));
                        _goals.Add(eternalGoal);
                        break;
                        case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), int.Parse(goalInfo[3]), int.Parse(goalInfo[4]), int.Parse(goalInfo[5]));
                        _goals.Add(checklistGoal);
                        break;
                        default:
                        break;
                    }
                }
            }
        }
        else{
            Console.WriteLine("File does not exist. Please create a new file.");
        }

    }
    public Goal FindGoal(List<Goal> goals){
        return goal;
    }
    public void UpdateGoal(int index){
        _goals[index].UpdateGoal();
    }
    public int GetTotalPoints(){
        int totalPoints = 0;
        foreach(Goal goal in _goals){
            totalPoints += goal.GetPoints();
        }
        return totalPoints;
    }
}