using System;

class DailyCalorieIntake
{
    static void Main()
    {
        int weightInPounds = int.Parse(Console.ReadLine());
        int heightInInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        double weightInKg = weightInPounds / 2.2;
        double heightInCm = heightInInches * 2.54;
        double BRM = 0;
        double workoutsConstant = 0;

        if (gender == 'm')
        {
            BRM = 66.5 + (13.75 * weightInKg) + (5.003 * heightInCm) - (6.755 * age);
        }
        else if (gender == 'f')
        {
            BRM = 655 + (9.563 * weightInKg) + (1.850 * heightInCm) - (4.676 * age);
        }

        if (workoutsPerWeek <= 0)
        {
            workoutsConstant = 1.2;
        }
        else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
        {
            workoutsConstant = 1.375;
        }
        else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)  
        {
            workoutsConstant = 1.55;
        }
        else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
        {
            workoutsConstant = 1.725;
        }
        else if (workoutsPerWeek > 9)
        {
            workoutsConstant = 1.9;
        }

        double DCI = BRM * workoutsConstant;
        Console.WriteLine(Math.Floor(DCI));
    }
}

