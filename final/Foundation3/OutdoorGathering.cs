using System;

class OutdoorGathering : Event
{
    // variables
    private string _weather;

    // constructor
    public OutdoorGathering(string title, string description, DateTime date, string time, string address, string weather) : base(title, description, date, time, address, "Outdoor Gathering"){
        _weather = weather;
    }

    // full details
    public override string fullDetails(){
    return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nType: {_type}\nWeather: {_weather}\n";
}
}