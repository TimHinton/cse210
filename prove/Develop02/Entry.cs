public class Entry
{
    public string _date;
    public string _text;
    public string _prompt;
    public string _tag;
    

    public Entry(string prompt, string text, string tag)
    {
        DateTime theDate = DateTime.Now;
        _date = theDate.ToShortDateString();
        _prompt = prompt;
        _text = text;
        _tag = tag;
    }

    public Entry(string prompt, string text, string date, string tag)
    {
        _prompt = prompt;
        _text = text;
        _date = date;
        _tag = tag;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine("");
    }
}