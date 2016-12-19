using System;

class WinningNumbers
{
    static void Main()
    {
        string inputStr = Console.ReadLine().ToLower();
        int letSum = 0;
        bool found = false;

        foreach (char ch in inputStr)
        {
            letSum += (ch - 'a') + 1;
        }

        for (int leftNumber = 100; leftNumber <= 999; leftNumber++)
        {
            for (int rightNumber = 100; rightNumber <= 999; rightNumber++)
            {
                int leftSum = CalculateNumberProduct(leftNumber);
                int rightSum = CalculateNumberProduct(rightNumber);
                bool isNumbersSumEqual = (leftSum == rightSum);

                if (isNumbersSumEqual && (leftSum == letSum) && (rightSum == letSum))
                {
                    Console.WriteLine("{0}-{1}", leftNumber, rightNumber);
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateNumberProduct(int number)
    {
        int numberSum = 1;
        
        while (number != 0)
        {
            numberSum *= number % 10;
            number /= 10;
        }
        return numberSum;
    }
}

