using System;

class FirefightingOrganization
{
    static void Main()
    {
        int firefighters = int.Parse(Console.ReadLine());

        int kidsSaved = 0;
        int adultsSaved = 0;
        int seniorsSaved = 0;

        string peopleInBuilding = Console.ReadLine();

        while (peopleInBuilding != "rain")
        {
            CalculatePeopleSaved(peopleInBuilding, firefighters,
                ref kidsSaved, ref adultsSaved, ref seniorsSaved);

            peopleInBuilding = Console.ReadLine();
        }

        Console.WriteLine("Kids: {0}", kidsSaved);
        Console.WriteLine("Adults: {0}", adultsSaved);
        Console.WriteLine("Seniors: {0}", seniorsSaved);
    }

    private static void CalculatePeopleSaved(string peopleInBuilding, int firefighters,
        ref int kidsSaved, ref int adultsSaved, ref int seniorsSaved)
    {

        if (firefighters >= peopleInBuilding.Length)
        {
            foreach (char person in peopleInBuilding)
            {
                switch (person)
                {
                    case 'K': kidsSaved++; break;
                    case 'A': adultsSaved++; break;
                    case 'S': seniorsSaved++; break;
                }
            }
        }
        else
        {
            int firefightersLeft = firefighters;
            char[] personsTypeArray = new char[] { 'K', 'A', 'S' };

            for (int person = 0; person < personsTypeArray.Length; person++)
            {
                char currentPersonType = personsTypeArray[person];

                for (int i = 0; i < peopleInBuilding.Length; i++)
                {
                    if (firefightersLeft <= 0)
                    {
                        break;
                    }

                    if (currentPersonType == peopleInBuilding[i])
                    {
                        switch (currentPersonType)
                        {
                            case 'K': kidsSaved++; break;
                            case 'A': adultsSaved++; break;
                            case 'S': seniorsSaved++; break;
                        }

                        firefightersLeft--;
                    }
                }
            }
        }
    }
}

