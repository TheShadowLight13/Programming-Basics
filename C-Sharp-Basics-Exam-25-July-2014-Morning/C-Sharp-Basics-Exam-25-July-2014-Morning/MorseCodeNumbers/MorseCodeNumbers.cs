using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int nSum = 0;
        int[] morseCodeValues = new int[] { 0, 1, 2, 3, 4, 5 };
        string[] morseCodeNumbers = new string[] { "-----", ".----", "..---", 
                                                   "...--", "....-", "....." };
        int morseNumbersCounter = 0;

        while (n > 0)
        {
            nSum += n % 10;
            n = n / 10;
        }

        for (int a = 0; a < morseCodeValues.Length; a++)
        {
            for (int b = 0; b < morseCodeValues.Length; b++)
            {
                for (int c = 0; c < morseCodeValues.Length; c++)
                {
                    for (int d = 0; d < morseCodeValues.Length; d++)
                    {
                        for (int e = 0; e < morseCodeValues.Length; e++)
                        {
                            for (int f = 0; f < morseCodeValues.Length; f++)
                            {
                                int morseProduct = a * b * c * d * e * f;
                                
                                if (morseProduct == nSum)
                                {
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|",
                                        morseCodeNumbers[a], morseCodeNumbers[b],
                                        morseCodeNumbers[c], morseCodeNumbers[d],
                                        morseCodeNumbers[e], morseCodeNumbers[f]);

                                    morseNumbersCounter++;
                                }
                               
                            }
                        }
                    }
                }
            }
        }

        if (morseNumbersCounter == 0)
        {
            Console.WriteLine("No");
        }
    }
}

