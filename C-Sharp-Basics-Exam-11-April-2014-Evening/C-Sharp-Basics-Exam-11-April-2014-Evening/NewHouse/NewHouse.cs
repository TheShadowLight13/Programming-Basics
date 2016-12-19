using System;

class NewHouse
{
    static void Main()
    {
        int buildingBaseHeight = int.Parse(Console.ReadLine());
        int roofHeight = (buildingBaseHeight / 2) + 1;
        int asterisk = 1;
        int dash = buildingBaseHeight / 2;

        for (int i = 0; i < roofHeight; i++)
        {
            Console.WriteLine("{0}{1}{0}", 
                new string('-', dash),
                new string('*', asterisk));
            dash--;
            asterisk += 2;
        }

        asterisk = buildingBaseHeight - 2;
        for (int i = 0; i < buildingBaseHeight; i++)
        {
            Console.WriteLine("|{0}|", new string('*', asterisk));
        }
    }
}

