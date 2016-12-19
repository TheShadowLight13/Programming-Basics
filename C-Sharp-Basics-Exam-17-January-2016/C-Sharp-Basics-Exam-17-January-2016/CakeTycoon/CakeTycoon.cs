using System;

class CakeTycoon
{
    static void Main()
    {
        ulong cakesWanted = ulong.Parse(Console.ReadLine());
        decimal flourKgsNeeded = decimal.Parse(Console.ReadLine());
        ulong flourKgsAvailable = ulong.Parse(Console.ReadLine());
        ulong trufflesAvailable = ulong.Parse(Console.ReadLine());
        ulong trufflePrice = ulong.Parse(Console.ReadLine());

        ulong cakesCapacity = (ulong)(flourKgsAvailable / flourKgsNeeded);

        if (cakesCapacity >= cakesWanted)
        {
            decimal truffleCost = trufflesAvailable * trufflePrice;
            decimal cakePrice = (truffleCost / cakesWanted) * 1.25M;

            Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
        }
        else
        {
            decimal totalFlourRequired = cakesWanted * flourKgsNeeded;
            decimal flourNeeeded = totalFlourRequired - flourKgsAvailable;

            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour",
                cakesCapacity, flourNeeeded);
        }
    }
}

