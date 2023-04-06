public class Running : Activity
{
    private decimal _distance;

    
    public Running(decimal minutes, decimal distance)
    {
        _date = SetDate();
        _type = "Running";
        _minutes = minutes;
        _distance = distance;
    }
    
    public override decimal GetDistance()
    {
        return _distance;
    }

    public override decimal GetSpeed()
    {
        return Math.Round((_distance / _minutes) * 60, 2);
    }

    public override decimal GetPace()
    {
        return Math.Round(_minutes / _distance, 2);
    }
}