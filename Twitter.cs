using System;
using static System.Console;


class Twitter
{
    static void Main()
    {
        Write("Enter Message: ");
        string message = ReadLine();

        if (message.Length >= 140)
        {
            Write("Rejected");
        }
        else if (message.Length <= 140)
        {
            Write("Posted");
        }

    }

    }








