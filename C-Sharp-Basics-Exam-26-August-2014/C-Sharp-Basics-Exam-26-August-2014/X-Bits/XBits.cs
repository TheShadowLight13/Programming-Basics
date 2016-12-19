using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        int xBitsCounter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            for (int bit = 0; bit < 32; bit++)
            {
                bool upX = ((numbers[i] >> bit) & 7) == 5;
                bool midX = ((numbers[i + 1] >> bit) & 7) == 2;
                bool downX = ((numbers[i + 2] >> bit) & 7) == 5;

                if (upX && midX && downX)
                {
                    xBitsCounter++;
                }
            }

        }
        Console.WriteLine(xBitsCounter);
    }
}
