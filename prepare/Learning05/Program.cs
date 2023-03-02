using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        Rectangle shape1 = new Rectangle("Indigo", 5, 3);
        list.Add(shape1);

        Square shape2 = new Square("Green", 4);
        list.Add(shape2);

        Circle shape3 = new Circle("Orange", 12);
        list.Add(shape3);

        foreach (Shape s in list)
        {
            string color = s.getcolor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape's area is {area}.");
        }
    }
}