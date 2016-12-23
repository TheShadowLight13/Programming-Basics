using System;

class ChangeTiles
{
    static void Main()
    {
        decimal availableMoney = decimal.Parse(Console.ReadLine());
        decimal floorWidth = decimal.Parse(Console.ReadLine());
        decimal floorHeight = decimal.Parse(Console.ReadLine());
        decimal plateSide = decimal.Parse(Console.ReadLine());
        decimal plateHeight = decimal.Parse(Console.ReadLine());
        decimal platePrice = decimal.Parse(Console.ReadLine());
        decimal moneyForCraftsman = decimal.Parse(Console.ReadLine());

        decimal floorArea = floorWidth*floorHeight;
        decimal plateArea = plateSide*(plateHeight/2.0M);
        decimal neededPlates = Math.Ceiling(floorArea/plateArea) + 5;
        decimal totalPrice = (neededPlates * platePrice) + moneyForCraftsman;

        if (totalPrice <= availableMoney)
        {
            decimal leftMoney = availableMoney - totalPrice;
            Console.WriteLine("{0:F2} lv left.", leftMoney);
        }
        else
        {
            decimal neededMoney = totalPrice - availableMoney;
            Console.WriteLine("You'll need {0:F2} lv more.", neededMoney);
        }
    }
}

