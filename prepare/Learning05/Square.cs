using System;

public class Square : Shape{
    // define variables
    private double _side = 0.0;
    
    // contructor
    public Square(string color, double side) : base (color){
        _side = side;
    }

    // get area override
    public override double GetArea(){
        double area = _side * _side;
        return area;
    }
}