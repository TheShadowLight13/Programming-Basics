using System;
using System.Globalization;

class Numerology
{
    static void Main()
    {
        string[] dateUsername = Console.ReadLine().Split(' ');
        DateTime date = DateTime.ParseExact(dateUsername[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
        string userName = dateUsername[1];
        long result = 0;
        long celestialNumber = 0;

        result = date.Day * date.Month * date.Year;
        if (date.Month % 2 != 0)
        {
            result *= result;
        }

        foreach (char ch in userName)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                result += (ch - 'a') + 1;
            }
            else if (ch >= '0' && ch <= '9')
            {
                result += (ch - '0');
            }
            else
            {
                result += ((ch - 'A') + 1) * 2;
            }
        }

        while (true)
        {
            celestialNumber += result % 10;
            result = result / 10;

            if (result == 0 && celestialNumber > 13)
            {
                result = celestialNumber;
                celestialNumber = 0;
            }
            else if (result == 0)
            {
                break;
            }
        }
        
        Console.WriteLine(celestialNumber);
    }
}

