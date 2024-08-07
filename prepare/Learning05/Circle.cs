public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        _color = color;
    }
    public override double GetArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2),2);
    }
}