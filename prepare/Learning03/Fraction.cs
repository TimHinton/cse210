using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public void setBot(int bottom)
    {
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBot()
    {
        return _bottom;
    }
}