using System;

class EmergencyRepairs
{
    static void Main()
    {
        ulong wallCondition = ulong.Parse(Console.ReadLine());
        int emergencyKits = int.Parse(Console.ReadLine());
        int attacks = int.Parse(Console.ReadLine());

        for (int i = 0; i < attacks; i++)
        {
            int attackedBit = int.Parse(Console.ReadLine());
            wallCondition &= ~(1UL << attackedBit);
        }

        for (int bit = 0; bit < 64; bit++)
        {
            int currentBit = bit;
            int consecutiveZeroBits = 0;

            while (currentBit < 64 && ((wallCondition >> currentBit) & 1) == 0)
            {
                currentBit++;
                consecutiveZeroBits++;
            }

            if (consecutiveZeroBits > 1)
            {
                while (consecutiveZeroBits > 0 && emergencyKits > 0)
                {
                    wallCondition |= 1UL << bit;
                    emergencyKits--;
                    bit++;
                    consecutiveZeroBits--;
                }
            }
        }

        Console.WriteLine(wallCondition);
    }
}

