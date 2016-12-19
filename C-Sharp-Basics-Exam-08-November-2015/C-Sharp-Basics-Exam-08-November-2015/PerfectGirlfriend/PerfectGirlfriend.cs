using System;
using System.Text.RegularExpressions;

class PerfectGirlfriend
{
    static void Main()
    {
        int perfectGirlfriends = 0;
        int dayOfWeekResult = 0;
        int phoneDigitsSum = 0;
        int braSizeResult = 0;
        int girlNameResult = 0;
        int totalResult = 0;
        
        string command = Console.ReadLine();

        while (command != "Enough dates!")
        {
            string dayOfWeek = command.Split('\\')[0];
            string phoneNumber = command.Split('\\')[1];
            string braSize = command.Split('\\')[2];
            string girlName = command.Split('\\')[3];

            switch (dayOfWeek)
            {
                case "Monday": dayOfWeekResult = 1; break;
                case "Tuesday": dayOfWeekResult = 2; break;
                case "Wednesday": dayOfWeekResult = 3; break;
                case "Thursday": dayOfWeekResult = 4; break;
                case "Friday": dayOfWeekResult = 5; break;
                case "Saturday": dayOfWeekResult = 6; break;
                case "Sunday": dayOfWeekResult = 7; break;
            }

            phoneDigitsSum = phoneNumberDigitsSum(phoneNumber);

            string numberInStr = Regex.Match(braSize, @"\d+").Value;
            braSizeResult = int.Parse(numberInStr) * char.Parse(braSize.Substring(numberInStr.Length, 1));
            
            girlNameResult = (int)(girlName[0] * girlName.Length);
            totalResult = (dayOfWeekResult + phoneDigitsSum + braSizeResult) - girlNameResult;

            if (totalResult >= 6000)
            {
                Console.WriteLine("{0} is perfect for you.", girlName);
                perfectGirlfriends++;
            }
            else
            {
                Console.WriteLine("Keep searching, {0} is not for you.", girlName);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(perfectGirlfriends);
    }

    private static int phoneNumberDigitsSum(string phoneNumber)
    {
        int digitsSum = 0;
        
        for (int i = 0; i < phoneNumber.Length; i++)
        {
            digitsSum += phoneNumber[i] - '0';
        }

        return digitsSum;
    }
}

