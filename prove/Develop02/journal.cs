using System;

public class Journal
{
    public string _name;
    public List<Entry> _Entries = new List<Entry>();

    public void DisplayJournal()
    {
        Console.WriteLine($"The Journal of {_name}");

        foreach (Entry entry in _Entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveJournal(string filename)
    {
        using (StreamWriter writter = new StreamWriter(filename))
        foreach(Entry entry in _Entries)
        {
            writter.WriteLine(entry);
        }
    }
    public void load(string filename)
    {
        String[] lines = System.IO.File.ReadAllLines(filename);
        Entry entry2 = new Entry();
        foreach(string x in lines)
        {
            _Entries.Add(entry2);
        }
    }
}