using System;

class Firm
{
    static void Main()
    {
        const double trainingRate = 0.1;
        const int workingDayTime = 8;
        const int overtimePerDay = 2;

        int neededHours = int.Parse(Console.ReadLine());
        int availableDays = int.Parse(Console.ReadLine());
        int workersOvertime = int.Parse(Console.ReadLine());

        double trainingTime = availableDays * trainingRate;
        int workingHours = (int)(((availableDays - trainingTime) * workingDayTime) +
            (workersOvertime * (overtimePerDay * availableDays)));

        if (neededHours <= workingHours)
        {
            int leftHours = workingHours - neededHours;
            Console.WriteLine($"Yes!{leftHours} hours left.");
        }
        else
        {
            int lackHours = neededHours - workingHours;
            Console.WriteLine($"Not enough time!{lackHours} hours needed.");
        }
    }
}

