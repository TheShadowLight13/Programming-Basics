using System;
using System.Text.RegularExpressions;

class TheFootballStatistician
{
    static int arsenalPoints = 0;
    static int chelseaPoints = 0;
    static int evertonPoints = 0;
    static int liverpoolPoints = 0;
    static int manchestarCityPoints = 0;
    static int manchestarUnitedPoints = 0;
    static int southamptonPoints = 0;
    static int tottenhamPoints = 0;
    
    static void Main()
    {
        
        string[] teamsInLeague = new string[]
        {"Arsenal", "Chelsea", "Everton", "Liverpool", 
         "Manchester City", "Manchester United", "Southampton", "Tottenham"};

        double paymentPerMatch = double.Parse(Console.ReadLine());
        double totalPayment = 0;

        string matchAndResult = Console.ReadLine();

        while (matchAndResult != "End of the league.")
        {
            totalPayment += paymentPerMatch;

            string[] matchAndResultArray = Regex.Split(matchAndResult, @"\s+");
            
            string firstTeam = matchAndResultArray[0];
            string matchOutcome = matchAndResultArray[1];
            string secondTeam = matchAndResultArray[2];

            if (matchOutcome == "1")
            {
                int firstTeamWinningPoints = 3;
                AllocatePoints(firstTeam, firstTeamWinningPoints);
            }
            else if (matchOutcome == "2")
            {
                int secondTeamWinningPoints = 3;
                AllocatePoints(secondTeam, secondTeamWinningPoints);
            }
            else if (matchOutcome == "X")
            {
                int firstTeamWinningPoints = 1;
                int secondTeamWinningPoints = 1;

                AllocatePoints(firstTeam, firstTeamWinningPoints);
                AllocatePoints(secondTeam, secondTeamWinningPoints);

            }

            matchAndResult = Console.ReadLine();
        }

        int[] teamPoints = new int[]{arsenalPoints, chelseaPoints, 
                                     evertonPoints, liverpoolPoints,
                                     manchestarCityPoints, manchestarUnitedPoints,
                                     southamptonPoints, tottenhamPoints};

        Console.WriteLine("{0:F2}lv.", totalPayment * 1.94);

        for (int i = 0; i < teamsInLeague.Length; i++)
        {
            Console.WriteLine("{0} - {1} points.", teamsInLeague[i], teamPoints[i]);
        }
    }

    private static void AllocatePoints(string team, int winningTeamPoints)
    {
        switch (team)
        {
            case "Arsenal": arsenalPoints += winningTeamPoints; break;
            case "Chelsea": chelseaPoints += winningTeamPoints; break;
            case "Everton": evertonPoints += winningTeamPoints; break;
            case "Liverpool": liverpoolPoints += winningTeamPoints; break;
            case "ManchesterCity": manchestarCityPoints += winningTeamPoints; break;
            case "ManchesterUnited": manchestarUnitedPoints += winningTeamPoints; break;
            case "Southampton": southamptonPoints += winningTeamPoints; break;
            case "Tottenham": tottenhamPoints += winningTeamPoints; break;
        }
    }
}

