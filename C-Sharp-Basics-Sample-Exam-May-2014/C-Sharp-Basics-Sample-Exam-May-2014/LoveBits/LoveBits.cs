using System;

class LoveBits
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long currentNumber = long.Parse(Console.ReadLine());
            long numberToReverse = currentNumber;

            long reversedNumber = 0;
            while (numberToReverse > 0)
            {
                reversedNumber <<= 1;
                reversedNumber |= (numberToReverse & 1);
                numberToReverse >>= 1;
            }

            long newNumber = (currentNumber ^ (~currentNumber)) & reversedNumber;
            Console.WriteLine(newNumber);
        }
    }
}

