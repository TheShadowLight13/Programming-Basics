using System;

class BitSequenceExchange
{
    static void Main()
    {

        long number = long.Parse(Console.ReadLine());

        //Get 3, 4, 5 bits value
        long thirdBitValue = (number >> 3) & 1;
        long fourthBitValue = (number >> 4) & 1;
        long fifthBitValue = (number >> 5) & 1;


        // Get 24, 25, 26 bits value
        long twentyFourBitValue = (number >> 24) & 1;
        long twentyFiveBitValue = (number >> 25) & 1;
        long twentySixBitValue = (number >> 26) & 1;

        // Set 3, 4, 5 bits to zero
        number &= ~(1 << 3);
        number &= ~(1 << 4);
        number &= ~(1 << 5);

        // Set 24, 25, 26 bits to zero
        number &= ~(1 << 24);
        number &= ~(1 << 25);
        number &= ~(1 << 26);

        // Swap 3 bit value with 24 bit
        number |= thirdBitValue << 24;
        number |= twentyFourBitValue << 3;

        // Swap 4 bit value with 25 bit
        number |= fourthBitValue << 25;
        number |= twentyFiveBitValue << 4;

        // Swap 5 bit value with 26 bit
        number |= fifthBitValue << 26;
        number |= twentySixBitValue << 5;

        Console.WriteLine(number);
    }
}


