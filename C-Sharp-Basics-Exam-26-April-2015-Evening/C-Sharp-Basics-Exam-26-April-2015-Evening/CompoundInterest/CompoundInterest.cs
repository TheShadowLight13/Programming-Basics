using System;

class CompoundInterest
{
    static void Main()
    {
        double tvPrice = double.Parse(Console.ReadLine());
        int term = int.Parse(Console.ReadLine());
        double bankInterestRate = double.Parse(Console.ReadLine());
        double friendInterestRate = double.Parse(Console.ReadLine());

        double bankLoanOffer = tvPrice * Math.Pow((1 + bankInterestRate), term);
        double friendLoanOffer = tvPrice * (1 + friendInterestRate);

        if (bankLoanOffer < friendLoanOffer)
        {
            Console.WriteLine("{0:F2} Bank", bankLoanOffer);
        }
        else if ((friendLoanOffer < bankLoanOffer) || (friendLoanOffer == bankLoanOffer))
        {
            Console.WriteLine("{0:F2} Friend", friendLoanOffer);
        }
    }
}

