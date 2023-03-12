using System;

class Program
{
    static void Main(string[] args)
    {
        Eternal eternalgoal = new Eternal();
        Simple simplegoal = new Simple();
        Checklist checklistgoal = new Checklist();
        Menu menu = new Menu();
        Player player1 = new Player();
        string name = menu.Startup();
        player1.SetUsername(name);
        List<Goal> Goallist = new List<Goal>();
        bool quit = true;
        
        while (quit)
        {
            int choice = menu.DisplayMenu();
            if (choice == 1)
            {
                int type = menu.DisplayTypes();
                if (type == 1)
                {
                    eternalgoal.SetGoal();
                    Goallist.Add(eternalgoal);
                }
                if (type == 2)
                {
                    simplegoal.SetGoal();
                    Goallist.Add(simplegoal);
                }
                if (type == 3)
                {
                    checklistgoal.SetGoal();
                    Goallist.Add(checklistgoal);
                }
                else
                {
                    Console.WriteLine("That was not a choice");
                }
            }
            if (choice == 2)
            {
                Console.WriteLine("Which goal are you recording an event for? :");
                int index = 1;
                foreach (Goal g in Goallist)
                {
                    Console.Write($"{index} ");
                    g.DisplayGoal();
                    index ++;
                }
                int num = int.Parse(Console.ReadLine());
                player1.LevelUp(Goallist[num - 1].CompleteGoal());
                player1.DisplayLevel();
            }
            if (choice == 3)
            {
                int index = 1;
                foreach (Goal g in Goallist)
                {
                    Console.Write($"{index}: ");
                    g.DisplayGoal();
                    index ++;
                }
            }
            if (choice == 6)
            {
                quit = false;
            }
            else Console.WriteLine(" ");
        }
        

    }
}