using System;

class BitCopy
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int bitPosition = int.Parse(Console.ReadLine());

        int bitValuePosition = (number >> bitPosition) & 1;

        const int bitCopyPosition = 2;
        int mask = 0;
        int newNumber = 0;

        if (bitValuePosition == 1)
        {
            mask = bitValuePosition << bitCopyPosition;
            newNumber = number | mask;
        }
        else if (bitValuePosition == 0)
        {
            mask = ~(1 << bitCopyPosition);
            newNumber = number & mask;
        }

        Console.WriteLine(newNumber);
    }
}

