using System;

class Activity
{
    protected int time; 
    public Menu menu = new Menu();
    public void DisplayIntro(string type, string description)
    {
        Console.WriteLine($"Welcome to the {type} activity!");
        Console.WriteLine(description);
        menu.DisplaySpinner(5);

    }
    public void DisplayOutro(string type, int x)
    {
        Console.WriteLine($"you have completed {x} seconds of the {type} activity!");
    }
    public void SetTime()
    {
        Console.Write("How long would you like to do the activity for?(seconds):");
        int y = int.Parse(Console.ReadLine());
        time = y;
    }
    public int GetTime()
    {
        return time;
    }
}