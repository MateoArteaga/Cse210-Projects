using System;

public class Scripture
{
    private string _reference;
    private List<string> _scripture = new List<string>();
    
    public Scripture(string words, string refe)
    {
        _scripture.AddRange(words.Split(' '));
        _reference = refe;
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
        int w = 0;
        while (w < _scripture.Count)
        {
            if (_scripture[w] == "____")
            {
                w++;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
       
}