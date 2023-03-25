public class Circle : Shape
{
    private double _radius;

    public Circle(string color, int radius) : base(color)
    {
        _color = color;
        _radius = radius;

    }

    public override double GetArea()
    {
        return (2 * 3.14 * (_radius * _radius));
    }

}