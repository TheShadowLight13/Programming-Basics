using System;

class PassionDays
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        int purchaseCounter = 0;

        string command = Console.ReadLine();

        while (!command.Equals("mall.Enter"))
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (!command.Equals("mall.Exit"))
        {
            for (int i = 0; i < command.Length; i++)
            {
                decimal itemValue = 0;

                if (char.IsUpper(command[i]))
                {
                    itemValue = command[i] * 0.5M;
                }
                else if (char.IsLower(command[i]))
                {
                    itemValue = command[i] * 0.3M;
                }
                else if (command[i].Equals('%'))
                {
                    itemValue = budget * 0.5M;
                }
                else if (command[i].Equals('*'))
                {
                    budget += 10;
                    continue;
                }
                else
                {
                    itemValue = command[i];
                }

                if (itemValue <= budget && itemValue > 0)
                {
                    budget -= itemValue;
                    purchaseCounter++;
                }
            }

            command = Console.ReadLine();
        }

        if (purchaseCounter == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:F2} lv.", budget);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", 
                purchaseCounter, budget);
        }
    }
}

