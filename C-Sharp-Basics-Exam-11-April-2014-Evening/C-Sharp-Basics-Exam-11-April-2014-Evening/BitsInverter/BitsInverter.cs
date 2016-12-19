using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                if ((index % step == 0) || (step == 1))
                {
                    int bitValue = (number >> bitIndex) & 1;
                    if (bitValue == 0)
                    {
                        number = number | (1 << bitIndex);
                    }
                    else if (bitValue == 1)
                    {
                        number = number ^ (1 << bitIndex);
                    }

                }
                index++;
            }
            
            Console.WriteLine(number);
        }
    }
}

