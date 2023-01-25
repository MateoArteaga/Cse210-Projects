using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("please enter your grade percentage:");
        string ValueFromUser = Console.ReadLine();
        int Grade = int.Parse(ValueFromUser);
        char LetterGrade = 'A';

        if(Grade >= 90)
        {
            LetterGrade = 'A';
            Console.WriteLine($"Wow! You got an {LetterGrade}, Congratulations!");
        }
        else if (Grade < 90 && Grade >= 80)
        {
            LetterGrade = 'B';
            Console.WriteLine($"A {LetterGrade} ain't Bad! Great job!");
        }
        else if (Grade < 80 && Grade >= 70)
        {
            LetterGrade = 'C';
            Console.WriteLine($"Ay, {LetterGrade}'s get degrees, am I right?");
        }
        else if (Grade < 70 && Grade >= 60)
        {
            LetterGrade = 'D';
            Console.WriteLine($"You got a {LetterGrade}, sorry pal, you did not pass.");
        }
        else if (Grade < 60)
        {
            LetterGrade = 'F';
            Console.WriteLine($"You failed with an {LetterGrade} in the class. Better luck next time!");
        }
        Console.WriteLine($"Your letter Grade is {LetterGrade}");
    }
}