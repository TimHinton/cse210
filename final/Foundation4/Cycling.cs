public class Cycling : Activity
{
    private decimal _speed;

    
    public Cycling(decimal minutes, decimal speed)
    {
        _date = SetDate();
        _type = "Cycling";
        _speed = speed;
        _minutes = minutes;
    }

    public override decimal GetDistance()
    {
        return Math.Round((_speed * _minutes) / 60, 2);
    }

    public override decimal GetSpeed()
    {
        return _speed;
    }

    public override decimal GetPace()
    {
        return Math.Round(_minutes / GetDistance(), 2);
    }
}