using System;

class Distance
{
    static void Main()
    {
        int initiallySpeed = int.Parse(Console.ReadLine());
        decimal firstTime = int.Parse(Console.ReadLine()) / 60.0M;
        decimal secondTime = int.Parse(Console.ReadLine()) / 60.0M;
        decimal thirdTime = int.Parse(Console.ReadLine()) / 60.0M;

        decimal currentSpeed = 0;

        decimal distanceWithInitiallySpeed = initiallySpeed*firstTime;

        currentSpeed = (initiallySpeed + (initiallySpeed * 0.1M));
        decimal distanceWithIncreasedSpeed = currentSpeed * secondTime;

        currentSpeed = (currentSpeed - (currentSpeed*0.05M));
        decimal distanceWithReducedSpeed = currentSpeed*thirdTime;

        decimal totalDistance = distanceWithInitiallySpeed + distanceWithIncreasedSpeed +
            distanceWithReducedSpeed;

        Console.WriteLine("{0:F2}", totalDistance);
    }
}

