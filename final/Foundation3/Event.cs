using System;

class Event
{

// variables
protected string _title;
protected string _description;
protected DateTime _date;
protected string _time;
protected string _address;
protected string _type;

// constructor
public Event(string title, string description, DateTime date, string time, string address, string type){
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
    _type = type;
}

// detail messages
public string standardDetails(){
    return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n";
}

public virtual string fullDetails(){
    return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nType: {_type}\n";
}

public string shortDescription(){
    return $"Type: {_type}\nTitle: {_title}\nDate: {_date}\n";
}

}