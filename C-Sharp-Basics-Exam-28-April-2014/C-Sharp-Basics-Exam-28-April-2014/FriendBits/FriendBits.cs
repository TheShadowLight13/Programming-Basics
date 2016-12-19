using System;

class FriendBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint friendBits = 0;
        uint aloneBits = 0;

        for (int bitIndex = 31; bitIndex >= 0; bitIndex--)
        {
            uint currentBit = (number >> bitIndex) & 1;

            bool hasLeftBit = bitIndex < 31;
            uint leftBit = (number >> (bitIndex + 1)) & 1;
            bool isLeftBitEqual = hasLeftBit & (leftBit == currentBit);

            bool hasRightBit = bitIndex > 0;
            uint rightBit = (number >> (bitIndex - 1)) & 1;
            bool isRightBitEqual = hasRightBit & (rightBit == currentBit);

            if (isLeftBitEqual || isRightBitEqual)
            {
                friendBits <<= 1;
                friendBits |= currentBit;
            }
            else
            {
                aloneBits <<= 1;
                aloneBits |= currentBit;
            }

        }
        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);

    }
}

