using System;

class Illuminati
{
    static void Main()
    {
        string message = Console.ReadLine();
        string upperCaseMessage = message.ToUpper();
        int vowelCounter = 0;
        int sumOfVowel = 0;

        foreach (char letter in upperCaseMessage)
        {
            if (letter == 'A' ||  letter == 'O' || 
                letter == 'U' || letter == 'E' || letter == 'I')
            {
                sumOfVowel += letter;
                vowelCounter++;
            }
        }


        Console.WriteLine(vowelCounter);
        Console.WriteLine(sumOfVowel);

    }
}

