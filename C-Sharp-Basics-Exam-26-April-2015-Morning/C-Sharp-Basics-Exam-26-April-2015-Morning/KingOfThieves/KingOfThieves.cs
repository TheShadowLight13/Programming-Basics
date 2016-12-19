using System;

class KingOfThieves
{
    static void Main()
    {
        int gemSize = int.Parse(Console.ReadLine());
        char gemType = char.Parse(Console.ReadLine());

        int dash = 0;
        int gemNumber = 1;

        dash = (gemSize - gemNumber) / 2;

        Console.WriteLine("{0}{1}{0}", new string('-', dash), gemType);
        
        for (int i = 0; i < gemSize - 1; i++)
        {
            if (i <= gemSize / 2 - 1)
            {
                dash--;
                gemNumber += 2;

                Console.WriteLine("{0}{1}{0}",
                new string('-', dash),
                new string(gemType, gemNumber));
            }
            else
            {
                dash++;
                gemNumber -= 2;

               Console.WriteLine("{0}{1}{0}",
               new string('-', dash),
               new string(gemType, gemNumber));
            }
        }
    }
}

