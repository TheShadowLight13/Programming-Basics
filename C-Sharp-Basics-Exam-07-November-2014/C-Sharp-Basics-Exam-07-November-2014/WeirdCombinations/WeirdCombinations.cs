using System;

class WeirdCombinations
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int counter = -1;
        bool found = false;

        for (int a = 0; a < inputStr.Length; a++)
        {
            for (int b = 0; b < inputStr.Length; b++)
            {
                for (int c = 0; c < inputStr.Length; c++)
                {
                    for (int d = 0; d < inputStr.Length; d++)
                    {
                        for (int e = 0; e < inputStr.Length; e++)
                        {
                            counter++;
                            if (counter == n)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}",
                                    inputStr[a], inputStr[b], inputStr[c],
                                    inputStr[d], inputStr[e]);
                                found = true;
                            }
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}

