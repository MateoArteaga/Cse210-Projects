using System;

class Program
{
 
    static void Main(string[] args)
    {
        var random = new Random();
        var list = new List<string>{"Who did you meet today?, What did you learn from them?","How did you see the Lords hand in your life today?","What can you improve on for tomorrow?","What did you do to reach your goals?","what simple things did you appreciate today?"};
        int index = random.Next(list.Count);
        bool Quit = true;
        Console.WriteLine("Hi, Welcome to your virtual journal");
        Console.Write("Please enter your name: ");
        Journal Journal1 = new Journal();
        Journal1._name = Console.ReadLine();
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: New Entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Save Journal to File");
            Console.WriteLine("4: Load Journal From File");
            Console.WriteLine("5: Quit");
            Console.Write("Your Choice:");
            int Choice = int.Parse(Console.ReadLine());
        
            if (Choice == 1)
            {
                Entry Entry1 = new Entry();
                Console.Write("please enter the date:");
                Entry1._date = Console.ReadLine();
                Console.WriteLine($"Your prompt for the day is:");
                Entry1._prompt = list[random.Next(list.Count)];
                Console.WriteLine(Entry1._prompt);
                Console.WriteLine("Your Entry:");
                Entry1._writing = Console.ReadLine();
                string save;
                Console.Write("Save Entry?(y/n):");
                save = Console.ReadLine();
                if (save == "n")
                {
                    Entry1._date = "";
                    Entry1._prompt = "";
                    Entry1._writing = "";
                }
                Journal1._Entries.Add(Entry1);
            }
            else if (Choice == 2)
            {
                Journal1.DisplayJournal();
            }
            else if(Choice ==3)
            {
                Console.WriteLine("Enter file name");
                string file = Console.ReadLine();
                Journal1.SaveJournal(file);
            }
            else if (Choice == 4)
            {
                Console.WriteLine("Enter file name");
                string file = Console.ReadLine();
                Journal1.load(file);
            }
            else if (Choice == 5)
            {
                Quit = false;
            }

        } while (Quit);
    }
}