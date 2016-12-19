using System;

class ChessboardGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputStr = Console.ReadLine();

        int blackTeamPoints = 0;
        int whiteTeamPoints = 0;

        for (int i = 0; i < inputStr.Length; i++)
        {
            if (i >= n * n)
            {
                break;                
            }
            
            if (i % 2 == 0 && char.IsUpper(inputStr[i]))
            {
                whiteTeamPoints += inputStr[i];
            }
            else if (i % 2 == 0 && char.IsLetterOrDigit(inputStr[i]))
            {
                blackTeamPoints += inputStr[i];
            }
            else if (i % 2 != 0 && char.IsUpper(inputStr[i]))
            {
                blackTeamPoints += inputStr[i];
            }
            else if (i % 2 != 2 && char.IsLetterOrDigit(inputStr[i]))
            {
                whiteTeamPoints += inputStr[i];
            }
        }

        if (blackTeamPoints == whiteTeamPoints)
        {
            Console.WriteLine("Equal result: {0}", blackTeamPoints);

        }
        else
        {
            Console.WriteLine(
                "The winner is: {0} team",
                blackTeamPoints > whiteTeamPoints ? "black" : "white");

            int diff = Math.Abs(blackTeamPoints - whiteTeamPoints);
            Console.WriteLine(diff);
        }
    }
}

