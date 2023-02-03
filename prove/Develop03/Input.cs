using System;

public class Input
{
    private bool _isenter = false;
    private bool _isquit = false;

    public bool Checkinput()
    {
        var x = Console.ReadKey();
        if(x.Key == ConsoleKey.Enter)
        {
            _isenter = true;
            return _isenter;
        }
        else if (x.Key == ConsoleKey.Q)
        {
            _isquit = false;
            return _isquit;
        }
        else return true;
    }

}
