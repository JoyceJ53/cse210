using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // create the list
        List<int> numbers = new List<int>();

        
        int userNumber = 1;
        while (userNumber != 0)
        {
            // get numbers from users
            Console.Write("Enter Number: ");
            userNumber = int.Parse(Console.ReadLine());
            // add user numbers to list
            numbers.Add(userNumber);
        }

        // calculate the sum of the list
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // calculate the average of the list
        int numberscount = numbers.Count;
        float average = ((float)sum) / numberscount;
        Console.WriteLine($"The average is: {average}");

        // find the largest number
        int largestnum = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largestnum)
            {
                largestnum = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestnum}");
    }
}