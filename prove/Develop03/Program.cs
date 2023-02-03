using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter Your favorite scripture reference: ");
        string reference = Console.ReadLine();
        Console.Write("Please enter the Text of the Scripture: ");
        string text = Console.ReadLine();
        Scripture scripture1 = new Scripture(text, reference);
        Input input = new Input();
        Console.WriteLine("press any button to remove a word\npress q to quit");
        scripture1.DisplayReference();
        scripture1.DisplayScripture();
        while (input.Checkinput() && scripture1.IsNotEmpty())
        {
            Console.Clear();
            Console.WriteLine("Press any button to remove a word\nPress q to quit");
            scripture1.RemoveWord();
            scripture1.DisplayReference();
            scripture1.DisplayScripture();
        }
    }
}