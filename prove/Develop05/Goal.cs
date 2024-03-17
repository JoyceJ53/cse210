using System;

public abstract class Goal{
    protected string _name;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public abstract int GetPoints();
    public abstract string FileInfo();
    public abstract void CreateGoal();
    public abstract void PrintGoal();
    public abstract void UpdateGoal();

}