using System;

class Program
{
    static void Main(string[] args)
    {
        // instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // create the list
        List<int> numbers = new List<int>();

        
        int zero = 1;
        while (zero != 0)
        {
            // get numbers from users
            Console.Write("Enter Number: ");
            int userNumber = int.Parse(Console.ReadLine());
            // add user numbers to list
            numbers.Add(userNumber);
        }
        // WE ARE HERE
        Console.WriteLine()
        // calculate the sum of the list
        // calculate the average of the list
        // find the largest number
    }
}