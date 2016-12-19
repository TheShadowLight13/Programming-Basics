using System;
using System.Linq;
using System.Collections.Generic;

class ArrayMatcher
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        char[] firstArray = input[0].ToCharArray();
        char[] secondArray = input[1].ToCharArray();
        string command = input[2];

        List<char> newArray = new List<char>();

        if (command == "join")
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (secondArray.Contains(firstArray[i]))
                {
                    newArray.Add(firstArray[i]);
                }
            }
        }
        else if (command == "left exclude")
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (!firstArray.Contains(secondArray[i]))
                {
                    newArray.Add(secondArray[i]);
                }
            }
        }
        else if (command == "right exclude")
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (!secondArray.Contains(firstArray[i]))
                {
                    newArray.Add(firstArray[i]);
                }
            }
        }

        newArray.Sort();
        foreach (char ch in newArray)
        {
            Console.Write(ch);
        }
    }
}

