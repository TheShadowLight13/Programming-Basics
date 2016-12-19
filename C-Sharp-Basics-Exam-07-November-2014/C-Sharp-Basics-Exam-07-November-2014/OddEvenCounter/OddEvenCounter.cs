using System;
using System.Linq;

class OddEvenCounter
{
    static void Main()
    {
        int countOfSets = int.Parse(Console.ReadLine());
        int numbersInSet = int.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();
        int[] oddOrEvenCount = new int[countOfSets];

        for (int set = 0; set < countOfSets; set++)
        {
            int counter = 0;

            for (int i = 0; i < numbersInSet; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (oddOrEven == "odd")
                {
                    if (currentNumber % 2 != 0)
                    {
                        counter++;
                    }
                }
                else
                {
                    if (currentNumber % 2 == 0)
                    {
                        counter++;
                    }
                }
            }
            oddOrEvenCount[set] = counter;
        }

        int mostNumbers = oddOrEvenCount.Max();
        int indexEvenNumbers = Array.IndexOf(oddOrEvenCount, mostNumbers);
        int mostNumbersSet = indexEvenNumbers + 1;
        string ordinalNumbersSet = "";

        switch (mostNumbersSet)
        {
            case 1: ordinalNumbersSet = "First"; break;
            case 2: ordinalNumbersSet = "Second"; break;
            case 3: ordinalNumbersSet = "Third"; break;
            case 4: ordinalNumbersSet = "Fourth"; break;
            case 5: ordinalNumbersSet = "Fifth"; break;
            case 6: ordinalNumbersSet = "Sixth"; break;
            case 7: ordinalNumbersSet = "Seventh"; break;
            case 8: ordinalNumbersSet = "Eighth"; break;
            case 9: ordinalNumbersSet = "Ninth"; break;
            case 10: ordinalNumbersSet = "Tenth"; break;
        }

        if (mostNumbers != 0)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}",
                ordinalNumbersSet, oddOrEven, mostNumbers);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

