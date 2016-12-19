using System;

class Nums
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        for (int currentNum = startNumber; currentNum <= endNumber; currentNum++)
        {
            if (currentNum % 2 == 0)
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(currentNum));
            }
            else
            {
                Console.WriteLine("{0:F3}", Math.Pow(currentNum, 2));
            }
        }
    }
}

