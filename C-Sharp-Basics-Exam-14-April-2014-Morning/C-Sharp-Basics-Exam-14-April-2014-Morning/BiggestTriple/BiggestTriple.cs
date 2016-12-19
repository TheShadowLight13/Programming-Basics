using System;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int triples = numbers.Length / 3;
        int leftNumbers = numbers.Length - triples * 3;
        int[] arrayTriplesNumbersSum = new int[numbers.Length];
        int counter = 0;
        int secondCounter = 0;

        for (int i = 0; i < triples; i++)
        {
            int sum = numbers[counter] + numbers[counter + 1] + numbers[counter + 2];
            arrayTriplesNumbersSum[secondCounter] = sum;
            counter += 3;
            arrayTriplesNumbersSum[secondCounter + 1] = int.MinValue;
            arrayTriplesNumbersSum[secondCounter + 2] = int.MinValue;
            secondCounter += 3;
        }

        if (leftNumbers == 0)
        {
            int index = Array.IndexOf(arrayTriplesNumbersSum, arrayTriplesNumbersSum.Max());
            Console.WriteLine("{0} {1} {2}", numbers[index], numbers[index + 1], numbers[index + 2]);
        }

        else if (leftNumbers == 1)
        {
            arrayTriplesNumbersSum[secondCounter] = int.MinValue;
            int sum = numbers[counter];

            if (sum > arrayTriplesNumbersSum.Max())
            {
                Console.WriteLine(numbers[counter]);
            }
            else
            {
                int index = Array.IndexOf(arrayTriplesNumbersSum, arrayTriplesNumbersSum.Max());
                Console.WriteLine("{0} {1} {2}", numbers[index], numbers[index + 1], numbers[index + 2]);

            }
        }
        else if (leftNumbers == 2)
        {
            arrayTriplesNumbersSum[secondCounter] = int.MinValue;
            arrayTriplesNumbersSum[secondCounter + 1] = int.MinValue;
            int sum = numbers[counter] + numbers[counter + 1];

            if (sum > arrayTriplesNumbersSum.Max())
            {
                Console.WriteLine("{0} {1}", numbers[counter], numbers[counter + 1]);
            }
            else
            {
                int index = Array.IndexOf(arrayTriplesNumbersSum, arrayTriplesNumbersSum.Max());
                Console.WriteLine("{0} {1} {2}", numbers[index], numbers[index + 1], numbers[index + 2]);

            }
        }
    }
}

