using System;

public class Rectangle : Shape{
    // define variables
    private double _length = 0.0;
    private double _width = 0.0;

    // constructor
    public Rectangle(string color, double length, double width) : base (color){
        _length = length;
        _width = width;
    }
    // get area override
    public override double GetArea(){
        double area = _length * _width;
        return area;
    }
}