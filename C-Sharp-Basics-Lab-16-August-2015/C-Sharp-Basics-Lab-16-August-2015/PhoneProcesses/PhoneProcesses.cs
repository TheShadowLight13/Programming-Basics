using System;

class PhoneProcesses
{
    static void Main()
    {
        string initialPower = Console.ReadLine();
        int power = int.Parse(initialPower.Replace("%", ""));

        bool needRecharge = false;
        bool isPhoneOff = false;
        int remainingPrograms = 0;

        string command = Console.ReadLine();

        while (!command.ToLower().Equals("end"))
        {
            if (power <= 0)
            {
                isPhoneOff = true;
            }
            else if (power <= 15)
            {
                needRecharge = true;
            }
            else
            {
                int currentAppConsumption = int.Parse(command.Substring(command.Length - 3, 2));
                power -= currentAppConsumption;
            }

            if (needRecharge || isPhoneOff)
            {
                remainingPrograms++;
                command = Console.ReadLine();
                continue;
            }

            command = Console.ReadLine();
        }

        if (power <= 0)
        {
            Console.WriteLine("Phone Off");
        }
        else if (power <= 15)
        {
            Console.WriteLine("Connect charger -> {0}%", power);
            Console.WriteLine("Programs left -> {0}", remainingPrograms);
        }
        else
        {
            Console.WriteLine("Successful complete -> {0}%", power);
        }
    }
}

