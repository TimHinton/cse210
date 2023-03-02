public class Entry
{
    public string _date = "";
    public string _text = "";
    public string _prompt = "";
    

    public Entry(string prompt, string text)
    {
        DateTime theDate = DateTime.Now;
        string _date = theDate.ToShortDateString();
        string _prompt = prompt;
        string _text = text;
    }

    public Entry(string prompt, string text, string date)
    {
        string _prompt = prompt;
        string _text = text;
        string _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine("");
    }

        public List<Entry> LoadEntries(List<Entry> entries)
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
}