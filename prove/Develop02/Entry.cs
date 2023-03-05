public class Entry
{
    public string _date = "";
    public string _text = "";
    public string _prompt = "";
    

    public Entry(string prompt, string text)
    {
        DateTime theDate = DateTime.Now;
        _date = theDate.ToShortDateString();
        _prompt = prompt;
        _text = text;
    }

    public Entry(string prompt, string text, string date)
    {
        _prompt = prompt;
        _text = text;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine("");
    }
}