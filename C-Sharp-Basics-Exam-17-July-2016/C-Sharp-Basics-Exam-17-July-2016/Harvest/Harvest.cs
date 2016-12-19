using System;

class Harvest
{
    static void Main(string[] args)
    {
        int vineyardArea = int.Parse(Console.ReadLine());
        double grapes = double.Parse(Console.ReadLine());
        int vineNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double totalGrapes = vineyardArea * grapes;
        double vineQuantity = 0.4 * totalGrapes / 2.5;

        if (vineQuantity >= vineNeeded)
        {
            double vineLeft = vineQuantity - vineNeeded;
            double vinePerPerson = vineLeft / workers;

            Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                Math.Floor(vineQuantity));
            Console.WriteLine("{0} liters left -> {1} liters per person.",
                Math.Ceiling(vineLeft), Math.Ceiling(vinePerPerson));
        }
        else 
        {
            double vineLack = vineNeeded - vineQuantity;

            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                Math.Ceiling(vineLack));
        }
    }
}

