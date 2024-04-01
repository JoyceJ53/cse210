using System;

class Program
{
    static void Main(string[] args)
    {
        // event instances
        Lecture lecture = new Lecture("Lecture Title", "Lecture Description", DateTime.Now, "1:00 PM", "123 Main Street", "Speaker Name", 10);
        Reception reception = new Reception("Reception Title", "Reception Description", DateTime.Now, "1:00 PM", "123 Main Street", "5Hg0z@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering Title", "Outdoor Gathering Description", DateTime.Now, "1:00 PM", "123 Main Street", "Rainy Weather");

        // print marketing messages
        Console.WriteLine();
        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lecture.standardDetails());
        Console.WriteLine(reception.standardDetails());
        Console.WriteLine(outdoorGathering.standardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:\n");
        Console.WriteLine(lecture.fullDetails());
        Console.WriteLine(reception.fullDetails());
        Console.WriteLine(outdoorGathering.fullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:\n");
        Console.WriteLine(lecture.shortDescription());
        Console.WriteLine(reception.shortDescription());
        Console.WriteLine(outdoorGathering.shortDescription());
        Console.WriteLine();


        // Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
    }
}