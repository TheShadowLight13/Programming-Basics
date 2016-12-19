using System;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;
        int obtainedBits = 0;
        int obtainedBitsCounter = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                if (!((index % step == 1) || (step == 1 && index > 0)))
                {
                    int bitValue = (number >> bitIndex) & 1;
                    obtainedBits = obtainedBits << 1;
                    obtainedBits = obtainedBits | bitValue;
                    obtainedBitsCounter++;
                }

                if (obtainedBitsCounter == 8)
                {
                    Console.WriteLine(obtainedBits);
                    obtainedBits = 0;
                    obtainedBitsCounter = 0;
                }
                index++;
            }
        }

        if (obtainedBitsCounter > 0)
        {
            obtainedBits = obtainedBits << (8 - obtainedBitsCounter);
            Console.WriteLine(obtainedBits);
        }
    }
}

