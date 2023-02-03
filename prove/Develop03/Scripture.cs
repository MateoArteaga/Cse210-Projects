using System;

public class Scripture
{
    private string _reference;
    private List<string> _scripture = new List<string>
    {
        "I", "can", "do", "all", "things", "through", "Christ", "which", "strengtheneth", "me"
    };
    
    public Scripture()
    {
        _reference = "Philippians 4:13";
    }
    public void AddWord(string word)
    {
       _scripture.Add(word);
    }
    public void SetReference(string refe)
    {
        _reference = refe;
    }
    public string GetReference()
    {
        return _reference;
    }
    public void DisplayScripture()
    {
        int i = 0;
        do
        {
            Console.Write($"{_scripture[i]} ");
            i++;
        } while (i < _scripture.Count);
        Console.WriteLine("");
    }
    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }
    public void RemoveWord()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,_scripture.Count);
        while (_scripture[number] == "____")
        {
            number = randomGenerator.Next(0,_scripture.Count);
        }
        _scripture[number] = "____";
    }
    public bool IsNotEmpty()
    {
       if (_scripture[0] == "____" && _scripture[1] == "____" && _scripture[2] == "____" && _scripture[3] == "____" && _scripture[4] == "____" && _scripture[5] == "____" && _scripture[6] == "____" && _scripture[7] == "____" && _scripture[8] == "____" && _scripture[9] == "____")
       {
        return false;
       }
       else
       {
        return true;
       }
    }
       
}