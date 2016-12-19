using System;

class DrunkAni
{
    static void Main()
    {
        long cabinsNumber = long.Parse(Console.ReadLine());
        
        long totalLengthCovered = 0;
        long currentPosition = 0;

        string nextCommand = Console.ReadLine();

        while (nextCommand != "Found a free one!")
        {
            long stepsNumber = long.Parse(nextCommand);

            long oldPosition = currentPosition;
            currentPosition = (currentPosition + stepsNumber) % cabinsNumber;
            long difference = currentPosition - oldPosition;

            totalLengthCovered += Math.Abs(difference);

            if (difference > 0)
            {
                Console.WriteLine("Go {0} steps to the right, Ani.", difference);

            }
            else if (difference < 0)
            {
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
            }
            else
            {
                Console.WriteLine("Stay there, Ani.");
            }

            nextCommand = Console.ReadLine();
        }

        Console.WriteLine("Moved a total of {0} steps.", totalLengthCovered);
    }
}

