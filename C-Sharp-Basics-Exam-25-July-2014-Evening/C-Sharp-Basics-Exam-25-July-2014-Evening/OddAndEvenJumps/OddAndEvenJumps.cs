using System;
using System.Text.RegularExpressions;

class OddAndEvenJumps
{
    static void Main()
    {
        string inputString = Console.ReadLine().ToLower();
        string strWithoutSpaces = Regex.Replace(inputString, "\\s+", "");

        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        long oddResult = 0;
        long evenResult = 0;

        int oddCounter = 0;
        int evenCounter = 0;

        for (int i = 0; i < strWithoutSpaces.Length; i+=2)
        {
            oddCounter++;
            if (oddCounter == oddJump)
            {
                oddResult = oddResult * strWithoutSpaces[i];
                oddCounter = 0;
            }
            else
            {
                oddResult += strWithoutSpaces[i];
            }

            if (i + 1 == strWithoutSpaces.Length)
            {
                break;
            }
            
            evenCounter++;
            if (evenCounter == evenJump)
            {
                evenResult = evenResult * strWithoutSpaces[i + 1];
                evenCounter = 0;
            }
            else
            {
                evenResult += strWithoutSpaces[i + 1];
            }
            
        }

        Console.WriteLine("Odd: " + Convert.ToString(oddResult, 16).ToUpper());
        Console.WriteLine("Even: " + Convert.ToString(evenResult, 16).ToUpper());
    }
}

