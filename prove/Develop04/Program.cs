using System;

class Program
{
    static void Main(string[] args)
    {
        Program pr = new Program();
        Menu menu = new Menu();
        int choice = menu.DisplayMenu();
        if (choice == 1)
        {
            pr.breathe();
        }
        else if (choice == 2)
        {
            pr.reflect();
        }
        else if (choice == 3)
        {
            pr.listen();
        }
        else if (choice == 4)
        {
            Console.WriteLine("Bye bye!");
        }
        else
        {
            Console.WriteLine("Not a valid input.");
        }
    }
    
    void listen()
    {
        Listen L = new Listen();
        L.SetTime();
        L.DisplayIntro("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        L.run();
        L.DisplayOutro("Listening", L.GetTime());
    }
    void breathe()
    {
        Breathe B = new Breathe();
        B.SetTime();
        B.DisplayIntro("Breathing", "This will lower your heart rate");
        B.run();
        B.DisplayOutro("Breathing", B.GetTime());
    }
    void reflect()
    {
        Reflection R = new Reflection();
        R.SetTime();
        R.DisplayIntro("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        R.run();
        R.DisplayOutro("Reflection", R.GetTime());
    }
}