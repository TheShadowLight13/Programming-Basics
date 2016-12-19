using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int firstDigit = 1; firstDigit < 10; firstDigit++)
        {
            for (int secondDigit = 1; secondDigit < 10; secondDigit++)
            {
                for (int thirdDigit = 1; thirdDigit < 10; thirdDigit++)
                {
                    for (int fourthDigit = 1; fourthDigit < 10; fourthDigit++)
                    {
                        if ((n % firstDigit == 0) && (n % secondDigit == 0) && 
                            (n % thirdDigit == 0) && (n % fourthDigit == 0))
                        {
                            Console.Write("{0}{1}{2}{3} ",
                                firstDigit, secondDigit, thirdDigit, fourthDigit);
                        }
                    }
                }
            }
        }
        
    }
}

