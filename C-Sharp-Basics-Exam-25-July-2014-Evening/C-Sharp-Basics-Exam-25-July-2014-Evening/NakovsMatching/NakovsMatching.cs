using System;
using System.Collections.Generic;

class NakovsMatching
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        int maxDiff = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 1; i <= firstStr.Length - 1; i++)
        {
            string leftFirstStr = firstStr.Substring(0, i);
            string rightFirstStr = firstStr.Substring(i);
            int leftFirstWeight = SumChars(leftFirstStr);
            int rightFirstWeight = SumChars(rightFirstStr);

            for (int j = 1; j <= secondStr.Length - 1; j++)
            {
                string leftSecondStr = secondStr.Substring(0, j);
                string rightSecondStr = secondStr.Substring(j);
                int leftSecondWeight = SumChars(leftSecondStr);
                int rightSecondWeight = SumChars(rightSecondStr);

                int diff =
                    Math.Abs((leftFirstWeight * rightSecondWeight) - (rightFirstWeight * leftSecondWeight));

                if (diff <= maxDiff)
                {
                    Console.WriteLine(
                        '(' + leftFirstStr + '|' + rightFirstStr + ") matches (" +
                          leftSecondStr + '|' + rightSecondStr + ") by " + diff + " nakovs");

                    found = true;
                }
            }

        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }

    private static int SumChars(string str)
    {
        int sum = 0;

        foreach (char ch in str)
        {
            sum += ch;
        }
        return sum;
    }
}

