using System;

class Program
{
    static void Main(string[] args)
    {
        string numberinput;
        List<int> numbers = new List<int>();
        Console.WriteLine("Create a list of numbers, type zero when done.");
        
        do
        {
        Console.Write("Enter Number(s):");
        numberinput = Console.ReadLine();
        numbers.Add(int.Parse(numberinput));
        } while (int.Parse(numberinput) != 0);
        
        int sum = numbers.Sum();
        Console.WriteLine($"The Sum is {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The Average is {average}");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}");

    }
}