public class Checklist : Goal
{
    string _Checklistgoal;
    int _times;
    public override void SetGoal()
    {
        Console.WriteLine("A checklist goal is a goal that needs to be completed a certain amount of times, completing all will earn 2000EXP!");
        Console.Write("Enter a checklist goal: ");
        _Checklistgoal = Console.ReadLine();
        Console.Write("How many times does this need to be done?: ");
        _times = int.Parse(Console.ReadLine());
    }
    public override string GetGoal()
    {
        string display = $"{_Checklistgoal}, {_times} more times to go";
        return display;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_Checklistgoal}, {_times} more times to go");
    }
    public override double CompleteGoal()
    {
        Console.WriteLine("Great Job! You earned 2000EXP!");
        return 2;
    }
}