using System;

class Money
{
    static void Main(string[] args)
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double yuans = double.Parse(Console.ReadLine());
        double commision = double.Parse(Console.ReadLine());

        double result = 0;
        double totalCommision = 0;

        double bitcoinsInBGL = bitcoins * 1168;
        double yuansInBGL = yuans * 0.15 * 1.76;

        result = (bitcoinsInBGL + yuansInBGL) / 1.95;
        totalCommision = (commision / 100) * result;

        result = result - totalCommision;
        Console.WriteLine(result);

    }
}

