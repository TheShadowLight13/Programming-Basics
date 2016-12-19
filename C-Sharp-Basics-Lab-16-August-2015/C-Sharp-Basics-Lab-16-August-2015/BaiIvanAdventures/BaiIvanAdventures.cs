using System;

class BaiIvanAdventures
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());
        double alcoholWantToDrink = double.Parse(Console.ReadLine());

        int alcoholPrice = 0;

        switch (dayOfWeek)
        {
            case 0: alcoholPrice = 25; break;
            case 1: alcoholPrice = 21; break;
            case 2: alcoholPrice = 14; break;
            case 3: alcoholPrice = 17; break;
            case 4: alcoholPrice = 45; break;
            case 5: alcoholPrice = 59; break;
            case 6: alcoholPrice = 42; break;
        }

        double alcoholDrunk = availableMoney / alcoholPrice;

        string condition = "";

        if (alcoholDrunk > 1.5)
        {
            condition = "very drunk";
        }
        else if (alcoholDrunk >= 1)
        {
            condition = "drunk";
        }
        else
        {
            condition = "sober";
        }

        if (alcoholDrunk > alcoholWantToDrink)
        {
            Console.WriteLine(
                "Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",
                condition, alcoholDrunk - alcoholWantToDrink);
        }
        else if (alcoholDrunk == alcoholWantToDrink)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
        }
        else
        {
            Console.WriteLine(
                "Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol",
                condition, alcoholWantToDrink - alcoholDrunk);
        }
    }
}

