using System;
using System.Collections.Generic;

class ByteParty
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }

        int mask = 1;
        string bitOperator = "";
        string orders = Console.ReadLine();

        while (orders != "party over")
        {
            string command = orders.Split()[0];
            int position = int.Parse(orders.Split()[1]);

            if (command.Equals("-1"))
            {
                mask = 1 << position;
                bitOperator = "^";
            }
            else if (command.Equals("0"))
            {
                mask = ~(1 << position);
                bitOperator = "&";
            }
            else if (command.Equals("1"))
            {
                mask = 1 << position;
                bitOperator = "|";
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = 0;
                
                if (bitOperator.Equals("^"))
                {
                    currentNumber = numbers[i] ^ mask;
                    numbers[i] = currentNumber;
                }
                else if (bitOperator.Equals("&"))
                {
                    currentNumber = numbers[i] & mask;
                    numbers[i] = currentNumber;
                }
                else if (bitOperator.Equals("|"))
                {
                    currentNumber = numbers[i] | mask;
                    numbers[i] = currentNumber;
                }
            }
            
            orders = Console.ReadLine();
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

