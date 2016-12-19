using System;

class LargestProductDigits
{
    static void Main()
    {
        string strNumber = Console.ReadLine();

        int largestProductDigits = 0;

        for (int i = 0; i < strNumber.Length - 5; i++)
        {
            int firstDigit = (int)(strNumber[i] - '0');
            int secondDigit = (int)(strNumber[i + 1] - '0');
            int thirdDigit = (int)(strNumber[i + 2] - '0');
            int fourthDigit = (int)(strNumber[i + 3] - '0');
            int fifthDigit = (int)(strNumber[i + 4] - '0');
            int sixthDigit = (int)(strNumber[i + 5] - '0');

            int currentProductDigits = 
                firstDigit * secondDigit * thirdDigit * fourthDigit * fifthDigit * sixthDigit;

            if (currentProductDigits > largestProductDigits)
            {
                largestProductDigits = currentProductDigits;
            }
        }

        Console.WriteLine(largestProductDigits);
    }
}

