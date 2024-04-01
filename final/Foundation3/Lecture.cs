using System;

class Lecture : Event
{
    // variables
    private string _speaker;
    private int _capacity;

    // constructor
    public Lecture(string title, string description, DateTime date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address, "Lecture"){
        _speaker = speaker;
        _capacity = capacity;
    }

    // full details
    public override string fullDetails(){
    return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nType: {_type}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
}
}