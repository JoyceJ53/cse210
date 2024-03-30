using System;

class Address
{
    // variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // USA?
    public bool IsInUSA(){
        if (_country == "USA"){
            return true;
        }
        else
        {
            return false;
        } 
    }

    // get full address
    public string GetFullAddress(){
        return $"{_streetAddress}\n    {_city}, {_state}, {_country}";
    }
}