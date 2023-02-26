using System;

class Breathe : Activity
{
    public void run()
    {
        int i = 0;
        while (i <= time - 1)
        {
            Console.WriteLine("Breathe in");
            menu.CountDown(5);
            i = i + 5;
            Console.WriteLine("Breathe Out");
            menu.CountDown(5);
            i = i + 5;
        }
    }
}