using System;

class HousePrice
{
    static void Main()
    {
        decimal smallestRoomArea = decimal.Parse(Console.ReadLine());
        decimal kitchenArea = decimal.Parse(Console.ReadLine());
        decimal squareMeterPrice = decimal.Parse(Console.ReadLine());

        decimal secondRoomArea = smallestRoomArea + smallestRoomArea*0.1M;
        decimal thirdRoomArea = secondRoomArea + secondRoomArea*0.1M;
        decimal bathroomArea = smallestRoomArea*0.5M;

        decimal totalArea = smallestRoomArea + kitchenArea + secondRoomArea + thirdRoomArea + bathroomArea;
        decimal corridorArea = totalArea*0.05M;

        totalArea += corridorArea;

        decimal totalPrice = totalArea*squareMeterPrice;
        Console.WriteLine("{0:F2}", totalPrice);
    }
}

