using System;

class Swimming : Activity
{
// variables
private double _laps;

// constructor
public Swimming(DateTime date, int length, double laps) : base(date, length, "Swimming"){
    _laps = laps;
}

// distance
public override double distance(){
    return (_laps * 50)/1000 * 0.62;
}

}