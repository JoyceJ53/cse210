using System;

abstract class Activity
{
// variables
protected DateTime _date;
private string _type;
// length in minutes
protected int _length; 

// constructor
public Activity(DateTime date, int length, string type){
    _date = date;
    _length = length;
    _type = type;
}

// The distance
public abstract double distance();

// The speed (miles per hour or kilometers per hour)
public virtual double speed(){
    return (distance()/_length)*60;
}

// The pace (minutes per mile or minutes per kilometer)
public virtual double pace(){
    return _length/distance();
}

// get summary
public virtual string GetSummary(){
    return $"{_date.ToString("dd MMM yyyy")} {_type} ({_length} min) - Distance {distance()} miles, Speed {speed().ToString("F2")} mph, Pace: {pace().ToString("F2")} min per mile";
}

}