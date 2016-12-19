using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int num = 555; num <= 999; num++)
        {
            int num1 = num;
            int num2 = num1 + diff;
            int num3 = num2 + diff;

            if (IsAllowedNumber(num1) && IsAllowedNumber(num2) && IsAllowedNumber(num3)
                && (num3 <= 999) && (CalculateSum(num1) + CalculateSum(num2) + CalculateSum(num3) == sum)) 
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                counter++;
            }
        }
        
        if (counter == 0)
        {
            Console.WriteLine("No");    
        }
    }

    private static bool IsAllowedNumber(int num)
    {
        string strNumber = num.ToString();

        foreach (var digit in strNumber)
        {
            if (digit < '5' || digit > '9')
            {
                return false;
            }

        }
        return true;
    }
    
    private static int CalculateSum(int num)
    {
        
        int sum = 0;
        
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10; 
        }
        return sum;
    }
}

