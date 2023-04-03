public class Gathering : Event
{
    private string _weather;

    public Gathering(string title, string desc, string date, string time, string address, string weather)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;

        _type = "Gathering";
    }

    public void GatheringDisplayFullDetails()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address}");
        Console.WriteLine($"The weather forcast for that day is {_weather}.");
    }
}