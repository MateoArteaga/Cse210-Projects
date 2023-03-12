public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Please select from the following:");
        Console.WriteLine("1 : Set new goal");
        Console.WriteLine("2 : Record Event");
        Console.WriteLine("3 : List Current Goals");
        Console.WriteLine("4 : Save Goals");
        Console.WriteLine("5 : Load Goals");
        Console.WriteLine("6 : Quit");
        return int.Parse(Console.ReadLine());
    }
    public string Startup()
    {
        Console.WriteLine("Welcome to The Eternal Quest!");
        Console.Write("Please Enter Your Name: ");
        return Console.ReadLine();
    }
    public int DisplayTypes()
    {
        Console.WriteLine("Which type of goal would you like to set?");
        Console.WriteLine("1 : Eternal Goal");
        Console.WriteLine("2 : Simple Goal");
        Console.WriteLine("3 : Checklist Goal");
        return int.Parse(Console.ReadLine());
    }
}