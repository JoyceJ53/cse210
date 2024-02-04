using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        File journal = new File();
        string userChoice = "1";

        while (userChoice != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    // Prompt Generator
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    // Entry
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;
                    
                    // Journal
                    journal._entries.Add(entry);
                    break;

                case "2":
                    Console.WriteLine("Entries:");
                    foreach (Entry singleEntry in journal._entries)
                    {
                        Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt}");
                        Console.WriteLine($"    {singleEntry._response}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Please enter the file you'd like to load:");
                    string fileName = Console.ReadLine();
                    journal._entries = journal.Load(fileName);
                    break;
                case "4":
                    Console.WriteLine("Please write the file would you like to save to:");
                    string userInput = Console.ReadLine();
                    journal.Save(journal._entries, userInput);
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        Console.WriteLine("");
    }
}