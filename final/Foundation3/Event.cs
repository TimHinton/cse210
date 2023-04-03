public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address}");
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine($"{_type}, {_title} on {_date}.");
    }
        
}