using System;
using System.Linq;

class Airlines
{
    static void Main()
    {
        int[] firstClassInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] businessClassInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] economyClassInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int firstClassPassengers = firstClassInfo[0];
        int businessClassPassengers = businessClassInfo[0];
        int economyClassPassengers = economyClassInfo[0];

        int firstFrequentFlyers = firstClassInfo[1];
        int businessFrequentFlyers = businessClassInfo[1];
        int economyFrequentFlyers = economyClassInfo[1];

        int mealInFirst = firstClassInfo[2];
        int mealInBusiness = businessClassInfo[2];
        int mealInEconomy = economyClassInfo[2];

        double firstClassIncome = (((firstClassPassengers - firstFrequentFlyers) * 7000) + 
            firstFrequentFlyers * (7000 * 0.3) + 
            mealInFirst * (7000 * 0.005));

        double businessClassIncome = (((businessClassPassengers - businessFrequentFlyers) * 3500) +
           businessFrequentFlyers * (3500 * 0.3) +
           mealInBusiness * (3500 * 0.005));

        double economyClassIncome = (((economyClassPassengers - economyFrequentFlyers) * 1000) +
           economyFrequentFlyers * (1000 * 0.3) +
           mealInEconomy * (1000 * 0.005));


        int allIncome = (int)(firstClassIncome + businessClassIncome + economyClassIncome);
        double maxIncome = ((12 * 7000) + (12 * (7000 * 0.005))) +
                        ((28 * 3500) + (28 * (3500 * 0.005))) +
                        ((50 * 1000) + (50 * (1000 * 0.005)));
        
        Console.WriteLine(allIncome);
        Console.WriteLine((int)(maxIncome - allIncome));

        
        
 

    }
}

