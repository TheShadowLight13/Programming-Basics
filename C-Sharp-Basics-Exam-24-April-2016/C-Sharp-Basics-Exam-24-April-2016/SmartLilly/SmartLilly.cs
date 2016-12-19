using System;

class SmartLilly
{
    static void Main()
    {
        int lillyAge = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toyCounter = 0;
        int moneyYearCounter = 0;
        double collectedMoney = 0;

        int bonusMoney = 0;

        for (int age = 1; age <= lillyAge; age++)
        {

            if (age % 2 == 0)
            {
                bonusMoney += 10;
                collectedMoney += bonusMoney;
                moneyYearCounter++;
            }
            else
            {
                toyCounter++;
            }
        }

        collectedMoney = collectedMoney + (toyCounter * toyPrice) - (moneyYearCounter * 1);

        double diffMoney = Math.Abs(collectedMoney - washingMachinePrice);

        if (collectedMoney >= washingMachinePrice)
        {
            Console.WriteLine("Yes! {0:F2}", diffMoney);
        }
        else
        {
            Console.WriteLine("No! {0:F2}", diffMoney);
        }
    }
}

