using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long maxValue = numbers.Max();
        long sumOfOtherNumbers = numbers.Sum() - maxValue;

        if (maxValue == sumOfOtherNumbers)
        {
            Console.WriteLine("Yes, sum={0}", maxValue);
        }
        else 
        {
            if (maxValue > sumOfOtherNumbers)
            {
                Console.WriteLine("No, diff={0}", maxValue - sumOfOtherNumbers);
            }
            else if (maxValue < sumOfOtherNumbers)
            {
                Console.WriteLine("No, diff={0}", sumOfOtherNumbers - maxValue);
            }
        }
    }
}

