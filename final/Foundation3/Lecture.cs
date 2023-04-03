public class Lecture : Event
{
    private string _capacity;
    private string _speaker;

    public Lecture(string title, string desc, string date, string time, string address, string capacity, string speaker)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
        _capacity = capacity;
        _speaker = speaker;

        _type = "Lecture";
    }

    public void LectureDisplayFullDetails()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address}");
        Console.WriteLine($"Guest speaker: {_speaker}. Capacity: {_capacity}");
    }
}