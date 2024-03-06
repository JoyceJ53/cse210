using System;

public abstract class Shape{
    // define variables
    private string _color = "";
    
    // color getter
    public string GetColor(){
    return _color;
    }

    // color setter
    public void SetColor(string color){
        _color = color;
    }

    // constructor that accepts and sets color
    public Shape(string color){
        _color = color;
    }

    // get area virtual method
    public abstract double GetArea();
}

