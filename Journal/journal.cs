// we are using system and system i0
using System;
using System.IO;

foreach (string line in lines)

// journal class
class Journal
{
    Journal()
    {
        Entries = new List<Entry>();
    }
    AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }
     DisplayJournal()
    {
        foreach(var entry in Entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
        }
    }
    SaveJournal(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine(entry.Date);
            }
        }
    }
    public void LoadJournal(string filename)
    {
        Entries.Clear();
        using (var reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                var prompt = reader.ReadLine();
                var response = reader.ReadLine();
                var date = reader.ReadLine();
                var entry = new Entry(prompt, response, date);
                Entries.Add(entry);
            }
        }
    }
}
//the Entry class
class Entry
{
    string Prompt =  prompt;
    string Response = response;
    string Date = date;
    Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
       // Date = date;
       DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    }
    
}
 // this is progaram class
class Program
{
    static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                var rand = new Random();
                var prompt = prompts[rand.Next(prompts.Count)];
                Console.WriteLine("Prompt: " + prompt);
                var response = Console.ReadLine();
                var date = DateTime.Now.ToString();
                journal.AddEntry(new Entry(prompt, response, date));
            }
   //         else if (choice == "2")
   { 
   foreach(JournalEntry line in AllEntry);

   }
   {
    Console.WriteLine(date);
    Console.WriteLine(prompt);
    console.WriteLine(entry)

   }
    