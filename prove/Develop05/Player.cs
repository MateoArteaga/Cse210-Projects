public class Player
{
    public string _username;
    public double _level = 0;
    public void LevelUp(double y)
    {
        _level = _level + y;
    }
    public void SetUsername(string x)
    {
        _username = x;
    }
    public void DisplayName()
    {
        Console.WriteLine(_username);
    }
    public void DisplayLevel()
    {
        Console.WriteLine($"you are now level {_level}");
    }

}