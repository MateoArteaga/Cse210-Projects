using System; 

public class Entry
{
    public string _date;
    public string _prompt;
    public string _writing;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}\n prompt:{_prompt}\n {_writing}");
    }
}