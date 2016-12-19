using System;

class ShuffleBits
{
    static void Main()
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());

        ulong newNumber = 0;
        bool isFirstNumberEqualBigger = false;

        if (firstNumber >= secondNumber)
        {
            isFirstNumberEqualBigger = true;
            newNumber = composeNewNumber(firstNumber, secondNumber, isFirstNumberEqualBigger);
        }
        else
        {
            isFirstNumberEqualBigger = false;
            newNumber = composeNewNumber(firstNumber, secondNumber, isFirstNumberEqualBigger);
        }

        Console.WriteLine(newNumber);
    }

    private static ulong composeNewNumber(ulong firstNumber, ulong secondNumber,
        bool isFirstNumberEqualBigger)
    {
        ulong newNumber = 0;

        ulong mask = 1;

        if (isFirstNumberEqualBigger)
        {
            for (int i = 31; i >= 0; i--)
            {
                // Get digit from first and second number       
                ulong firstNumberDigit = (firstNumber >> i) & mask;
                ulong secondNumberDigit = (secondNumber >> i) & mask;

                // Set digits from upper numbers in new number
                newNumber <<= 1;
                newNumber |= firstNumberDigit;

                newNumber <<= 1;
                newNumber |= secondNumberDigit;
            }
        }
        else
        {
            for (int i = 31; i > 0; i-=2)
            {
                // Get two digits from first and second number       
                ulong firstNumberDigitOne = (firstNumber >> i) & mask;
                ulong firstNumberDigitTwo = (firstNumber >> (i - 1)) & mask;
                
                ulong secondNumberDigitOne = (secondNumber >> i) & mask;
                ulong secondNumberDigitTwo = (secondNumber >> (i - 1)) & mask;

                // Set digits from upper numbers in new number
                newNumber <<= 1;
                newNumber |= firstNumberDigitOne;
                newNumber <<= 1;
                newNumber |= firstNumberDigitTwo;

                newNumber <<= 1;
                newNumber |= secondNumberDigitOne;
                newNumber <<= 1;
                newNumber |= secondNumberDigitTwo;
            }
        }
        
        return newNumber;
    }
}

