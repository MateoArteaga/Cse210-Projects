public class Simple : Goal
{
    string _Simplegoal;

    public override void SetGoal()
    {
        Console.WriteLine("A simple goal is completed one time, and awards 1000EXP!");
        Console.Write("Enter a simple goal: ");
        _Simplegoal = Console.ReadLine();
    }
    public override String GetGoal()
    {
        return _Simplegoal;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine(_Simplegoal);
    }
    public override double CompleteGoal()
    {
        Console.WriteLine("Great Job! You Earned 1000EXP!");
        return 1;
    }
}