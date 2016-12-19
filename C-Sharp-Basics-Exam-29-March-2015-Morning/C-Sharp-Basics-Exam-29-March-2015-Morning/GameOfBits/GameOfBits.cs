using System;

class GameOfBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        uint newNumber = number;
        int countOfBits = 0;
        int oneBits = 0;

        while (command != "Game Over!")
        {
            countOfBits = CountBits(newNumber);

            if (command == "Odd")
            {
                newNumber = OddBits(countOfBits, newNumber);

            }
            else if (command == "Even")
            {
                newNumber = EvenBits(countOfBits, newNumber);
            }

            command = Console.ReadLine();
        }

        countOfBits = CountBits(newNumber);
        for (int i = countOfBits - 1; i >= 0; i--)
        {
            uint currentBit = (newNumber >> i) & 1;
            if (currentBit == 1)
            {
                oneBits++;
            }
        }

        Console.WriteLine("{0} -> {1}", newNumber, oneBits);
    }

    private static uint OddBits(int countOfBits, uint number)
    {
        uint newNumber = 0;

        for (int i = countOfBits - 1; i >= 0; i--)
        {
            if ((i + 1) % 2 != 0)
            {
                uint currentBit = (number >> i) & 1;
                newNumber <<= 1;
                newNumber |= currentBit;

            }
        }
        return newNumber;
    }

    private static uint EvenBits(int countOfBits, uint number)
    {
        uint newNumber = 0;

        for (int i = countOfBits - 1; i >= 0; i--)
        {
            if ((i + 1) % 2 == 0)
            {
                uint currentBit = (number >> i) & 1;
                newNumber <<= 1;
                newNumber |= currentBit;

            }
        }
        return newNumber;
    }

    private static int CountBits(uint number)
    {
        int bitsCounter = 0;

        while (number != 0)
        {
            bitsCounter++;
            number >>= 1;
        }
        return bitsCounter;
    }
}

