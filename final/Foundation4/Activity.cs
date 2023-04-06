public abstract class Activity
{
    protected string _date;
    protected decimal _minutes;
    protected string _type;


    public string SetDate()
    {
        DateTime date =  DateTime.Today;
        return date.ToString("d");
    }
    public abstract decimal GetDistance();

    public abstract decimal GetSpeed();

    public abstract decimal GetPace();

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}