using System;

class Reception : Event
{
    // variables
    private string _email;

    // constructor
    public Reception(string title, string description, DateTime date, string time, string address, string email) : base(title, description, date, time, address, "Reception"){
        _email = email;
    }
    
    // full details
    public override string fullDetails(){
    return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nType: {_type}\nRSVP: {_email}\n";
}
}