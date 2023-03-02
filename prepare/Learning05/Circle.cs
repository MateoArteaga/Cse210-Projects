public class Circle : Shape
{
    private double _diameter;
    public Circle(string color, double diameter) : base (color)
    {
        _diameter = diameter;
    }
    public override double GetArea()
    {
        double area = (.25) * Math.PI * _diameter * _diameter;
        return area;
    }
}