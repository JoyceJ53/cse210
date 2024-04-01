using System;

class Running : Activity
{
// variables
private double _distance;

// constructor
public Running(DateTime date, int length, double distance) : base(date, length, "Running"){
    _distance = distance;
}

public override double distance(){
    return _distance;
}

}