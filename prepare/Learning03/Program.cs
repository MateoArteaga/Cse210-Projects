using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"The default fraction is: {fraction1.GetFractionString()}");

        Fraction fraction2 = new Fraction(7);
        Console.WriteLine($"the number seven as a fraction is {fraction2.GetFractionString()}");

        Fraction fraction3 = new Fraction(17,23);
        Console.WriteLine($"the new fraction is {fraction3.GetFractionString()} ");

        Console.Write($"what should we change the top of {fraction3.GetFractionString()} to?: ");
        int newtop = int.Parse(Console.ReadLine());
        fraction3.SetTop(newtop);
        Console.WriteLine($"Great! the new fraction is {fraction3.GetFractionString()}");
        Console.WriteLine($"It's Decimal Value is {fraction3.GetDecimalValue()}");

        Console.WriteLine("Let's create one more fraction!");
        Console.Write("Please enter the top: ");
        int top = int.Parse(Console.ReadLine());
        Console.Write("please enter the bottom: ");
        int bottom = int.Parse(Console.ReadLine());
        Fraction fraction4 = new Fraction(top, bottom);
        Console.WriteLine($"top:{fraction4.GetTop()}\nbottom:{fraction4.GetBottom()}\nTogether: {fraction4.GetFractionString()}\ndecimal value: {fraction4.GetDecimalValue()}");
    }
}