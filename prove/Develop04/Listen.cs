using System;

class Listen : Activity
{
    private string[] prompts = new string[5]{ "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    List<string> List = new List<string>();
    public void run()
    {
        int i = 0;
        while (i <= time - 1)
        {
            Random rnd = new Random();
            Console.WriteLine(prompts[rnd.Next(0, prompts.Count())]);
            menu.DisplaySpinner(5);
            List.Add(Console.ReadLine());
            i = i + 5;
        }
        Console.WriteLine($"You Have Completed {List.Count} questions!");
    }
}