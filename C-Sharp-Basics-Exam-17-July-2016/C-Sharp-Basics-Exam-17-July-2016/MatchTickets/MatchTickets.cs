using System;

class MatchTickets
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string ticketCategory = Console.ReadLine();
        int peopleInGroup = int.Parse(Console.ReadLine());

        double percentForTransport = 0;
        double ticketPrice = 0;

        if (peopleInGroup <= 4)
        {
            percentForTransport = 0.75;
        }
        else if (peopleInGroup >= 5 && peopleInGroup <= 9)
        {
            percentForTransport = 0.6;
        }
        else if (peopleInGroup >= 10 && peopleInGroup <= 24)
        {
            percentForTransport = 0.5;
        }
        else if (peopleInGroup >= 25 && peopleInGroup <= 49)
        {
            percentForTransport = 0.4;
        }
        else
        {
            percentForTransport = 0.25;
        }

        double transportPrice = budget * percentForTransport;
        budget = budget - transportPrice;

        if (ticketCategory.Equals("Normal"))
        {
            ticketPrice = 249.99 * peopleInGroup;
        }
        else
        {
            ticketPrice = 499.99 * peopleInGroup;
        }

        if (budget > ticketPrice)
        {
            double moneyLeft = budget - ticketPrice;

            Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
        }
        else
        {
            double moneyNeeded = ticketPrice - budget;

            Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyNeeded);
        }

    }
}

