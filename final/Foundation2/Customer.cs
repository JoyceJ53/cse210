using System;

class Customer
{
    // variables
    private string _name;
    private Address _address;

    // constructor
    public Customer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        _address = new Address(streetAddress, city, state, country);
    }

    // getters
    public string GetName(){return _name;}
    public string GetAddress(){return _address.GetFullAddress();}

    // USA?
    public bool IsInUSA(){
        return _address.IsInUSA();
    }

}