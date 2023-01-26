using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1._name = "Jefferey Flounder";

        Job job1 = new Job();
        job1._company = "Tesla Motors";
        job1._title = "Electrical Physicist";
        job1._startyear = "2006";
        job1._endyear = "2013";

        Job job2 = new Job();
        job2._company = "Jeff's Electric Cars";
        job2._title = "CEO";
        job2._startyear = "2013";
        job2._endyear = "2022";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}