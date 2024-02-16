using System;
using System.Data;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {

        string filePath = "Proverbs.txt";
        Scripture scripture = new Scripture();
        bool quit = true;
        Word word = new Word(scripture);
        
        string reference = "";
        List<string> verse = new List<string>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            reference = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] lines = line.Split(' ');
                foreach (string l in lines){
                    verse.Add(l);
            }
                }
        }
        scripture.SetWords(verse);
        string renderedScripture = scripture.RenderedScripture();

        // while loop to keep the program running until the user types quit
        while (quit)
        {
            
            renderedScripture = word.ReplaceWords(renderedScripture);
            Console.Clear();
            Console.Write(reference + " ");
            Console.WriteLine($"\n{renderedScripture}.\n");
            
            

            // foreach (string w in verse)
            // {
            //     Console.Write(w + " ");
            // }
            
        // enter to continue, or type quit to exit
            Console.WriteLine("Press Enter to continue, or type quit to exit.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                quit = false;
            }
        // check if the scripture is completely hidden
            string[] shouldQuit = renderedScripture.Split(' ');
            bool scriptureIsHidden = scripture.ScriptureIsHidden(shouldQuit);
            if (scriptureIsHidden)
            {
                quit = false;
            }
        }
    }
}