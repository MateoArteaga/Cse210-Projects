using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Johnny Doctor", "Multiplication");
        Console.WriteLine(a.GetSummary());

        MathAssignment b = new MathAssignment("Albert Stein", "Relativity", "1.1", "1-25");
        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomeworkList());

        WritingAssignment c = new WritingAssignment("Thing1", "childrens books", "My Best Friend Thing2");
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWritingInformation());
    }
}