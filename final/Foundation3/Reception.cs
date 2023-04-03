public class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, string address, string email)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
        _email = email;

        _type = "Reception";
    }

    public void ReceptionDisplayFullDetails()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address}");
        Console.WriteLine($"RSVP to {_email}.");
    }
}