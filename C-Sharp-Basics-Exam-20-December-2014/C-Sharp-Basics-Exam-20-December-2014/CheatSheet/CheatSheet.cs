﻿using System;

class CheatSheet
{
    static void Main()
    {
        long rows = long.Parse(Console.ReadLine());
        long cols = long.Parse(Console.ReadLine());
        long vNumber = long.Parse(Console.ReadLine());
        long hNumber = long.Parse(Console.ReadLine());

        for (long row = vNumber; row < vNumber + rows; row++)
        {
            for (long col = hNumber; col < hNumber + cols; col++)
            {
                Console.Write(row * col);

                if (col < hNumber + cols - 1)
                {
                    Console.Write(' ');
                }
            }
            
            Console.WriteLine();
        }

    }
}

