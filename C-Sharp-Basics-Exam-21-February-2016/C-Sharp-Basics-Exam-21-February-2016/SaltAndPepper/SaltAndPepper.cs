using System;

class SaltAndPepper
{
    static void Main()
    {
        ulong dishes = ulong.Parse(Console.ReadLine());

        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string spice = input.Split()[0];
            int step = int.Parse(input.Split()[1]);

            dishes = SetBits(dishes, spice, step);

            input = Console.ReadLine();
        }

        Console.WriteLine(dishes);
    }

    private static ulong SetBits(ulong dishes, string spice, int step)
    {
        ulong mask = 1UL;

        for (int i = 0; i < 64; i+=step)
        {
            mask <<= i;

            if (spice.Equals("salt"))
            {
                mask = ~mask;
                dishes &= mask;
            }
            else
            {
                dishes |= mask;
            }
            mask = 1UL;
        }
        return dishes;
    }
}

