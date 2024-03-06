using System;

public class Circle : Shape{
    // define variables
    private double _radius = 0.0;

    // constructor
    public Circle(string color, double radius) : base (color){
        _radius = radius;
    }

    // get area override
    public override double GetArea(){
        double area = _radius * _radius * Math.PI;
        return area;
    }
}