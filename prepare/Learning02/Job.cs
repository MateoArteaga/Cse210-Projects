using System;

public class Job
{
    public string _company;
    public string _title;
    public string _startyear;
    public string _endyear;

    public void DisplayJob()
    {
        Console.WriteLine($"{_company}, {_title}, {_startyear} - {_endyear}");
    }
}