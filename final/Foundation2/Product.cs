using System;

class Product
{
    // variables
    private string _name;
    private int _productId;
    private double _pricePerUnit;

    // quantity getter and setter
    public int Quantity { get; set; }

    // getters
    public string GetName(){return _name;}
    public int GetProductId(){return _productId;}
    public double GetPricePerUnit(){return _pricePerUnit;}

    // constructor
    public Product(string name, int productId, double pricePerUnit){
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
    }

    // product total
    public double GetProductTotal(){
        return _pricePerUnit * Quantity;
    }
}