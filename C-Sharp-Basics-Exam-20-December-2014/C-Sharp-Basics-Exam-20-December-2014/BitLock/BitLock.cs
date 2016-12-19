using System;
using System.Linq;

class BitLock
{
    static void Main()
    {
        
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commands = input.Split();
        
            if (commands[0] == "check")
            {
                int colToCheck = int.Parse(commands[1]);
                int onesInCol = CheckColumn(colToCheck, numbers);
                Console.WriteLine(onesInCol);
            }
            else
            {
                int row = int.Parse(commands[0]);
                string direction = commands[1];
                int rotations = int.Parse(commands[2]) % 12;

                if (direction == "left")
                {
                    MoveLeft(row, rotations, numbers);
                }
                else if (direction == "right")
                {
                    MoveRight(row, rotations, numbers);
                }
            }

            input = Console.ReadLine();
        }
        Console.Write(string.Join(" ", numbers));
    }

    private static int CheckColumn(int colToCheck, int[] numbers)
    {
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int bitValue = (numbers[i] >> colToCheck) & 1;
            
            if (bitValue == 1)
            {
                counter++;
            }
        }
        return counter;
    }

    private static void MoveLeft(int row, int rotations, int[] numbers)
    {
        for (int i = 0; i < rotations; i++)
        {
            int mostLeftBit = (numbers[row] >> 11) & 1;
            numbers[row] &= ~(1 << 11);
            numbers[row] <<= 1;
            numbers[row] |= mostLeftBit;
        }
    }

    private static void MoveRight(int row, int rotations, int[] numbers)
    {
        for (int i = 0; i < rotations; i++)
        {
            int mostRightBit = numbers[row] & 1;
            numbers[row] >>= 1;
            numbers[row] |= (mostRightBit << 11);
        }
    }
}

