using System;

class WaveBits
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        int bestSequenceLength = 0;
        int bestSequenceStartIndex = 0;
        int currentSequenceLength = 1;

        for (int i = 0; i <= 61; i++)
        {
            bool isFirstBitUp = ((number >> i) & 1) == 1;
            bool isSecondBitDown = ((number >> i + 1) & 1) == 0;
            bool isThirdBitUp = ((number >> i + 2) & 1) == 1;

            bool isWaveTriple = isFirstBitUp && isSecondBitDown && isThirdBitUp;

            if (isWaveTriple)
            {
                currentSequenceLength += 2;

                if (currentSequenceLength > bestSequenceLength)
                {
                    bestSequenceStartIndex = i + 2;
                    bestSequenceLength = currentSequenceLength;
                }
                
                i++;
            }
            else
            {
                currentSequenceLength = 1;
            }
        }

        int bestSequenceEndIndex = bestSequenceStartIndex - bestSequenceLength + 1;
        ulong outputNumber = 0UL;
        
        for (int i = 63; i >= 0; i--)
        {
            bool isShouldBeDeletedRange = i <= bestSequenceStartIndex && i >= bestSequenceEndIndex;

            if (isShouldBeDeletedRange)
            {
                outputNumber >>= 1;
            }
            else
            {
                ulong currentBit = number & (1UL << i);
                outputNumber |= currentBit;
            }
        }

        if (bestSequenceLength > 0)
        {
            Console.WriteLine(outputNumber);
        }
        else
        {
            Console.WriteLine("No waves found!");
        } 
    }
}

