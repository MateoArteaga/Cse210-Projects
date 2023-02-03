using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Program pr = new Program();
        int choice = menu.DisplayMenu();
        if (choice == 1)
        {
        Console.Write("Please enter Your favorite scripture reference: ");
        string reference = Console.ReadLine();
        Console.Write("Please enter the Text of the Scripture: ");
        string text = Console.ReadLine();
        Scripture scripture = new Scripture(text, reference);
        pr.Memorize(scripture);
        }
        else if (choice == 2)
        {
            Scripture choice2 = menu.DisplayList();
            pr.Memorize(choice2);
        }
        else if (choice == 3)
        {
            Scripture choice3 = menu.RandomScripture();
            pr.Memorize(choice3);
        }
        else
        {
            Console.WriteLine("please try again");
        }
        
    }
    public void Memorize(Scripture x)
    {
    Input input = new Input();
    Console.WriteLine("press any button to remove a word\npress q to quit");
    x.DisplayReference();
    x.DisplayScripture();
    while (input.Checkinput() && x.IsNotEmpty())
    {
        Console.Clear();
        Console.WriteLine("Press any button to remove a word\nPress q to quit");
        x.RemoveWord();
        x.DisplayReference();
        x.DisplayScripture();
    }
    }
}   
