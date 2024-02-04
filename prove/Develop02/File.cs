using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;
public class File
{
    public List<Entry> _entries = new List<Entry>();

    public void Save(List<Entry> entries, string fileName)
    {
        using (StreamWriter writer = new StreamWriter($"{fileName}.txt", true))
        {
            foreach(Entry entry in entries)
            {
                writer.WriteLine(entry._entryDate);
                writer.WriteLine($"    {entry._prompt}");
                writer.WriteLine($"    {entry._response}");
            }
        }
    Console.WriteLine("Your file has been saved.");
    }   
    public List<Entry> Load(string fileName)
    {
        List<Entry> loadedEntries = new List<Entry>();

        using (StreamReader reader = new StreamReader($"{fileName}.txt"))
        {
            while(!reader.EndOfStream)
            {
                string dateLine = reader.ReadLine();
                string promptLine = reader.ReadLine();
                string responseLine = reader.ReadLine();
                Entry loadedEntry = new Entry();

                Console.WriteLine($"{dateLine}\n{promptLine}\n{responseLine}");
                Console.WriteLine("");

                DateTime date;
                if (DateTime.TryParse(dateLine, out date))
                {
                    loadedEntry._entryDate = date;
                    loadedEntry._prompt = promptLine.Trim();
                    loadedEntry._response = responseLine.Trim();
                    loadedEntries.Add(loadedEntry);
                }
                else
                {
                    Console.WriteLine($"Invalid date format in the file. Please check and correct the file format");
                }
                loadedEntry._entryDate = date;
            }
        }
        return loadedEntries;
    }
}