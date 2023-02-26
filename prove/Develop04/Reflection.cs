using System;

class Reflection : Activity
{
    private string[] prompts = new string[4]{ "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] question = new string[6]{ "Why was this experience meaningful to you?", "How did you get started?", "How did you feel when it was complete?", "Have you ever done anything like this before?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?"};
    public void run()
    {
        int i = 0;
        while (i <= time - 1)
        {
        Random rnd = new Random();
        Console.WriteLine(prompts[rnd.Next(0, prompts.Count())]);
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
        Console.WriteLine(question[rnd.Next(0, question.Count())]);
        menu.DisplaySpinner(10);
        i = i + 10;
        }
    }
}