using System;
using System.Numerics;

class TribonacciNumbers
{
    static void Main()
    {
        BigInteger firstTribonacci = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTribonacci = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTribonacci = BigInteger.Parse(Console.ReadLine());
        BigInteger nTribonacci = BigInteger.Parse(Console.ReadLine());

        BigInteger nextTribonacci = 0;

        for (int i = 3; i < nTribonacci; i++)
        {
            nextTribonacci = firstTribonacci + secondTribonacci + thirdTribonacci;
            firstTribonacci = secondTribonacci;
            secondTribonacci = thirdTribonacci;
            thirdTribonacci = nextTribonacci;
        }

        if (nTribonacci == 1)
        {
            Console.WriteLine(firstTribonacci);
        }
        else if (nTribonacci == 2)
        {
            Console.WriteLine(secondTribonacci);
        }
        else if (nTribonacci == 3)
        {
            Console.WriteLine(thirdTribonacci);
        }
        else
        {
            Console.WriteLine(nextTribonacci);
        }

    }
}

