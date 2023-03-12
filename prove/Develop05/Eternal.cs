public class Eternal : Goal
{
    string _Eternalgoal;
    public override void SetGoal()
    {
        Console.WriteLine("An eternal goal is one that is never complete and can be done multiple times");
        Console.WriteLine("Each time an eternal goal is completed, you are awarded 500EXP!");
        Console.Write("Enter an eternal goal: ");
        _Eternalgoal = Console.ReadLine();
    }
    public override string GetGoal()
    {
        return _Eternalgoal;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine(_Eternalgoal);
    }
    public override double CompleteGoal()
    {
        Console.WriteLine("Great Job! You Earned 500EXP!");
        return 0.5;
    }
}