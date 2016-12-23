using System;

class FlowerShop
{
    static void Main()
    {
        int magnoliasCount = int.Parse(Console.ReadLine());
        int hyacinthsesCount = int.Parse(Console.ReadLine());
        int rosesCount = int.Parse(Console.ReadLine());
        int cactusesCount = int.Parse(Console.ReadLine());
        decimal giftPrice = decimal.Parse(Console.ReadLine());

        decimal magnoliaPrice = 3.25M;
        decimal hyacinthsPrice = 4.00M;
        decimal rosePrice = 3.50M;
        decimal cactusPrice = 8.00M;

        decimal totalProfit = (magnoliaPrice*magnoliasCount) + (hyacinthsPrice*hyacinthsesCount) +
                              (rosePrice*rosesCount) + (cactusPrice*cactusesCount);
        decimal duty = totalProfit*0.05M;

        totalProfit -= duty;

        if (totalProfit >= giftPrice)
        {
            int leftMoney = (int)Math.Floor(totalProfit - giftPrice);
            Console.WriteLine("She is left with {0} leva.", leftMoney);
        }
        else
        {
            int neededMoney = (int)Math.Ceiling(giftPrice - totalProfit);
            Console.WriteLine("She will have to borrow {0} leva.", neededMoney);
        }
    }
}

