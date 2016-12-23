using System;

class MaxCombination
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int maxCombinations = int.Parse(Console.ReadLine());

        for (int first = start; first <= end; first++)
        {
            for (int second = start; second <= end; second++)
            {
                if (maxCombinations <= 0)
                {
                    return;
                }

                Console.Write("<{0}-{1}>", first, second);
                maxCombinations--;
            }
        }
    }
}

