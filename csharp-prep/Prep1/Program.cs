using System;

class Program
{
    static void Main(string[] args)
    {
        // gets the user's first name and saves it in the string: (first_name)
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        // gets the user's last name and saves it in the string: (last_name)
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}