using System;
using System.Linq;

class BitShooter
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong mask = 1;
        int tempVar = 0;
        int leftSideBitsSurvive = 0;
        int rightSideBitsSurvive = 0;


        for (int i = 0; i < 3; i++)
        {
            int[] centerSizeShoot = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int centerShoot = centerSizeShoot[0];
            int sizeShoot = centerSizeShoot[1];
            tempVar = centerShoot;
            int leftBitSize = (sizeShoot - 1) / 2;
            int rightBitSize = (sizeShoot - 1) / 2;
            mask = ~((ulong)1 << centerShoot);

            number = number & mask;

            centerShoot--;
            while (rightBitSize > 0 && centerShoot >= 0)
            {
                mask = ~((ulong)1 << centerShoot);
                number = number & mask;
                centerShoot--;
                rightBitSize--;
            }

            centerShoot = tempVar + 1;
            while (leftBitSize > 0 && centerShoot <= 63)
            {

                mask = ~((ulong)1 << centerShoot);
                number = number & mask;
                centerShoot++;
                leftBitSize--;
            }

        }

        mask = (long)1;
        
        for (int i = 0; i < 32; i++)
        {
            ulong bit = (number >> i) & mask;

            if (bit == 1)
            {
                rightSideBitsSurvive++;
            }
        }

        for (int i = 32; i < 64; i++)
        {
            ulong bit = (number >> i) & mask;

            if (bit == 1)
            {
                leftSideBitsSurvive++;
            }
        }

        Console.WriteLine("left: {0}", leftSideBitsSurvive);
        Console.WriteLine("right: {0}", rightSideBitsSurvive);
        
    }
}

