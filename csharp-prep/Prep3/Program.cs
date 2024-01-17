using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // random number generator
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        Console.WriteLine($"What is the magic number? {randomNumber}");

        int userNumber = -1;

        // while user number doesn't equal random number
        while (randomNumber != userNumber)
        {
            Console.Write("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());
            // if the number is higher
            if (userNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            // if the number is lower
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            // when they guess the correct number.
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}