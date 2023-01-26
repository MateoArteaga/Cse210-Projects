using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            string number = Console.ReadLine();
            return int.Parse(number);
        }
        static int SquareNumber(int number)
        {
            double value = number;
            return Math.Sqrt(number);
            
        }
    }
}