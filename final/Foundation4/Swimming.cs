public class Swimming : Activity
{
    private decimal _laps;

    
    public Swimming(decimal minutes, decimal laps)
    {
        _date = SetDate();
        _type = "Swimming";
        _laps = laps;
        _minutes = minutes;
    }
    
    public override decimal GetDistance()
    {
        return Math.Round((_laps * 50) / 620, 2);
    }

    public override decimal GetSpeed()
    {
        return Math.Round((GetDistance() / _minutes) * 60, 2);
    }

    public override decimal GetPace()
    {
        return Math.Round((_minutes / GetDistance()), 2);
    }
}