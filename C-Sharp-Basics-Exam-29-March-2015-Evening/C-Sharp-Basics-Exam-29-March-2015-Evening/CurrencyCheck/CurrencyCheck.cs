using System;

class CurrencyCheck
{
    static void Main()
    {
        long rubles = long.Parse(Console.ReadLine());
        long dollars = long.Parse(Console.ReadLine());
        long euro = long.Parse(Console.ReadLine());
        long siteBLeva = long.Parse(Console.ReadLine());
        long siteMLeva = long.Parse(Console.ReadLine());
        
        double rublesInLeva = (double)rubles / 100 * 3.5;
        double dollarsInLeva = dollars * 1.5;
        double euroInLeva = euro * 1.95;
        double siteBGamePrice = (double)siteBLeva / 2;

        double lowestPrice = double.MaxValue;
        lowestPrice = Math.Min(rublesInLeva, lowestPrice);
        lowestPrice = Math.Min(dollarsInLeva, lowestPrice);
        lowestPrice = Math.Min(euroInLeva, lowestPrice);
        lowestPrice = Math.Min(siteBGamePrice, lowestPrice);
        lowestPrice = Math.Min(siteMLeva, lowestPrice);
        
        Console.WriteLine("{0:F2}", lowestPrice);
    }
}

