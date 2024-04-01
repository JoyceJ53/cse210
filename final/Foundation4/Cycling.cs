using System;

class Cycling : Activity
{
    // variables
    private double _speed;

    // constructor
    public Cycling(DateTime date, int length, double speed) : base(date, length, "Cycling"){
        _speed = speed;
    }

    // distance
    public override double distance(){
        return _length/pace();
    }

    // speed
    public override double speed(){
        return _speed;
    }

    // pace
    public override double pace(){
        return 60/speed();
    }
}