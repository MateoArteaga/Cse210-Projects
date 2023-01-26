using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        Console.WriteLine($"the magic number is {number}");
        string response;
        do
        {
            Console.Write("What is your guess?");
            response = Console.ReadLine();
            if (int.Parse(response) > number)
            {
                Console.WriteLine("Lower");
            }
            else if (int.Parse(response) < number)
            {
                Console.WriteLine("Higher");
            }
        
        } while (int.Parse(response) != number);
        Console.WriteLine("you got it!");
    }
}