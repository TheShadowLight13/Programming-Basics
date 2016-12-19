using System;

class BitSwap
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        int mask = 1;

        //Get 3 bit value
        long thirdBitValue = (number >> 3) & 1;
        
        // Get 24 bit value
        long twentyFourBitValue = (number >> 24) & 1;

        // Set 3 bit to zero
        mask = ~(1 << 3);
        number &= mask;
 
        // Set 24 bit to zero
        mask = ~(1 << 24);
        number &= mask;

        // Swap 3 bit value with 24 bit
        number |= thirdBitValue << 24;
        number |= twentyFourBitValue << 3;

        Console.WriteLine(number);
    }
}

