public abstract class Shape
{
    private string _color;
    public string getcolor()
    {
        return _color;
    }
    public void setcolor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}