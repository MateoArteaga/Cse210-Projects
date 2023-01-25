using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("What is your first name?");
        string namefirst = Console.ReadLine();
        Console.Write("What is your last name?");
        String namelast = Console.ReadLine();
        Console.WriteLine($"Your name is {namelast}, {namefirst} {namelast}.");
        
    }
}