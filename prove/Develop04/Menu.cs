 using System;

class Menu
{
    public void DisplaySpinner(int x)
    {
        int t = 0;
        while (t < x)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            t++;
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            t++;
        }
    }
    public void CountDown(int z)
    {
        int t = z;
        while(t > 0)
        {
            Console.Write(t);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            t--;
        }
    }
    public int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfullness program!");
        Console.WriteLine("Please Choose From the Following:");
        int choice;
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listening Activity");
        Console.WriteLine("4. Exit.");
        Console.Write("Please Enter Your Choice:");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
}