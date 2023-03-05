using System;
using System.IO;

class Program
{
    static string Menu()
    {
        // This will be the main menu for the program and returns the number choice
        Console.WriteLine("Select one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        string response = Console.ReadLine();
        Console.WriteLine("");

        return response;
    }

    static List<Entry> LoadEntries(List<Entry> entries)
    {
        // Get the filename from the user
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        // Use filename to retrieve the entries
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Iterate through each line, create Entry object, add to Entry list
        foreach (string line in lines)
        {
            string[] pieces = line.Split("`");

            string date = pieces[0];
            string text = pieces[1];
            string prompt = pieces[2];

            Entry newEntry = new Entry(prompt, text, date);
            entries.Add(newEntry);
        }

        return entries;
    }


    static void SaveEntries(List<Entry> entries)
    {
        // Get the filename from user
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        // Use filename to save Entries as strings
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                string entryString = $"{entry._date}`{entry._text}`{entry._prompt}";
                outputFile.WriteLine(entryString);
            }
        }
    }

    static void Main(string[] args)
    {
        // Initialize entry list
        List<Entry> entryList = new List<Entry>();

        // Initialize prompts list
        Prompt
        prompt = new Prompt();
        prompt.Populate();

        // Loop exiter
        int loop = 1;

        while (loop == 1)
        {
            // Display menu
            string response = Menu();

            while (response != "1" && response != "2" && response != "3" && response != "4" && response != "5")
            {
                Console.WriteLine("Not a valid answer, select a choice (1 - 5)");
                response = Console.ReadLine();
                Console.WriteLine();
            }

            // Logic for menu choice
            if (response == "1")
            {
                string newPrompt = prompt.RandoString();
                Console.WriteLine(newPrompt);
                string responseText = Console.ReadLine();
                Entry newEntry = new Entry(newPrompt, responseText);
                entryList.Add(newEntry);
                Console.WriteLine();
            }

            else if (response == "2")
            {
                if (entryList.Count == 0)
                {
                    Console.WriteLine("There are no items to display");
                }
                else
                {
                    foreach (Entry entry in entryList)
                    {
                        entry.Display();
                    }
                }
            }

            else if (response == "3")
            {
                LoadEntries(entryList);
            }

            else if (response == "4")
            {
                SaveEntries(entryList);
            }

            else
            {
                loop --;
            }
        }
        
        
    }
}