using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        Input input = new Input();
        Console.WriteLine("press any button to remove a word\npress q to quit");
        scripture1.DisplayReference();
        scripture1.DisplayScripture();
        while (input.Checkinput() & scripture1.IsNotEmpty())
        {
            Console.Clear();
            Console.WriteLine("Press any button to remove a word\nPress q to quit");
            scripture1.RemoveWord();
            scripture1.DisplayReference();
            scripture1.DisplayScripture();
        }
    }
}