using System;

class HungryGarfield
{
    static void Main()
    {
        decimal budgetInUSD = decimal.Parse(Console.ReadLine());
        decimal dollarExchangeRate = decimal.Parse(Console.ReadLine());
        decimal pizzaPriceBGL = decimal.Parse(Console.ReadLine());
        decimal lasagnaPriceBGL = decimal.Parse(Console.ReadLine());
        decimal sandwichPriceBGL = decimal.Parse(Console.ReadLine());
        long pizzaQuantity = long.Parse(Console.ReadLine());
        long lasagnaQuantity = long.Parse(Console.ReadLine());
        long sandwichQuantity = long.Parse(Console.ReadLine());

        decimal totalPizzaPriceUSD = (pizzaPriceBGL / dollarExchangeRate) * pizzaQuantity;
        decimal totalLasagnaPriceUSD = (lasagnaPriceBGL / dollarExchangeRate) * lasagnaQuantity;
        decimal totalSandwichPriceUSD = (sandwichPriceBGL / dollarExchangeRate) * sandwichQuantity;

        decimal moneySpended = totalPizzaPriceUSD + totalLasagnaPriceUSD + totalSandwichPriceUSD;

        if (moneySpended <= budgetInUSD)
        {
            decimal moneyLeft = budgetInUSD - moneySpended;
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.",
                moneyLeft);
        }
        else
        {
            decimal moneyNeeded = moneySpended - budgetInUSD;
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.",
                moneyNeeded);
        }
    }
}

