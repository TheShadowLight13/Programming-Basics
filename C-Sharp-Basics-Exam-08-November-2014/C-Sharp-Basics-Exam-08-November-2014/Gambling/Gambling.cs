using System;
using System.Threading;
using System.Globalization;

class Gambling
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        double cash = double.Parse(Console.ReadLine());
        string[] houseHand = Console.ReadLine().Split();
        
        int houseStrength = 0;
        const double possibleHands = 28561;
        double winningHands = 0;
        double winningHandProbability = 0;
        double expectedWinnings = 0;
        string foldOrDraw = "";

        foreach (var item in houseHand)
        {
            switch (item)
            {
                case "J": houseStrength += 11; break;
                case "Q": houseStrength += 12; break;
                case "K": houseStrength += 13; break;
                case "A": houseStrength += 14; break;
                default: houseStrength += int.Parse(item); break;
            }
        }

        for (int card1 = 2; card1 <= 14; card1++)
        {
            for (int card2 = 2; card2 <= 14; card2++)
            {
                for (int card3 = 2; card3 <= 14; card3++)
                {
                    for (int card4 = 2; card4 <= 14; card4++)
                    {
                        if ((card1 + card2 + card3 + card4) > houseStrength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }

        winningHandProbability = (winningHands / possibleHands) * 100;
        if (winningHandProbability > 50)
        {
            foldOrDraw = "DRAW";
        }
        else
        {
            foldOrDraw = "FOLD";
        }

        expectedWinnings = ((2 * cash) * winningHandProbability) / 100;

        Console.WriteLine(foldOrDraw);
        Console.WriteLine("{0:F2}", expectedWinnings);
    }
}

