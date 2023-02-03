using System;

class Menu
{

    private Scripture _scripture1 = new Scripture("But behold, I, Nephi, will show unto you that the tender mercies of the Lord are over all those whom he hath chosen, because of their faith, to make them mighty even unto the power of deliverance", "1 Nephi 1:20");
    private Scripture _scripture2 = new Scripture("Adam fell that men might be; and men are, that they might have joy","2 Nephi 2:25");
    private Scripture _scripture3 = new Scripture("These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world","John 16:33");
    private Scripture _scripture4 = new Scripture("Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost","Matthew 28:19");
    private Scripture _scripture5 = new Scripture("Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.", "Isaiah 41:10");
    private Scripture _scripture6 = new Scripture("And now, if your joy will be great with one soul that you have brought unto me into the kingdom of my Father, how great will be your joy if you should bring many souls unto me!","D&C 18:16");
    public int DisplayMenu()
    {

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Choose an option from below");
        Console.WriteLine("1: Type In a scripture to memorize");
        Console.WriteLine("2: Choose from a list of scriptures to memorize");
        Console.WriteLine("3: Random Scripture to memorize");
        return int.Parse(Console.ReadLine());
    }
    public Scripture DisplayList()
    {
        Console.WriteLine("Choose one from below");
        Console.Write("1: ");
        _scripture1.DisplayReference();
        _scripture1.DisplayScripture();
        Console.Write("2: ");
        _scripture2.DisplayReference();
        _scripture2.DisplayScripture();
        Console.Write("3: ");
        _scripture3.DisplayReference();
        _scripture3.DisplayScripture();
        Console.Write("4: ");
        _scripture4.DisplayReference();
        _scripture4.DisplayScripture();
        Console.Write("5: ");
        _scripture5.DisplayReference();
        _scripture5.DisplayScripture();
        Console.Write("6: ");
        _scripture6.DisplayReference();
        _scripture6.DisplayScripture();
        int choice2 = int.Parse(Console.ReadLine());
        if (choice2 == 1)
        {
            return _scripture1;
        }
        else if (choice2 == 2)
        {
            return _scripture2;
        }
        else if (choice2 ==3)
        {
            return _scripture3;
        }
        else if (choice2 == 4)
        {
            return _scripture4;
        }
        else if (choice2 == 5)
        {
            return _scripture5;
        }
        else if (choice2 == 6)
        {
            return _scripture6;
        }
        else
        {
            Console.WriteLine("Not a choice, Giving scripture.");
            return _scripture1;
        }
    }
    public Scripture RandomScripture()
    {
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1,6);
        if (x == 1)
        {
            return _scripture1;
        }
        else if (x == 2)
        {
            return _scripture2;
        }
        else if (x == 3)
        {
            return _scripture3;
        }
        else if (x == 4)
        {
            return _scripture4;
        }
        else if (x == 5)
        {
            return _scripture5;
        }
        else if (x == 6)
        {
            return _scripture6;
        }
        else
        {
            return _scripture1;
        }
    }
}