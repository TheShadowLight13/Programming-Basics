using System;

class AccountInformation
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int clientId = int.Parse(Console.ReadLine());
        double accountBalance = double.Parse(Console.ReadLine());

        string isBalancePositive = "no";
        
        if (accountBalance >= 0)
        {
            isBalancePositive = "yes";
        }

        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        Console.WriteLine("Client id: {0}", clientId);
        Console.WriteLine("Total balance: {0:F2}", accountBalance);
        Console.WriteLine("Active: {0}", isBalancePositive);
                         
    }
}

