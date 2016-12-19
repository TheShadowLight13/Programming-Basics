using System;
using System.Globalization;

class SudokuResults
{
    static void Main()
    {
        int countOfGames = 0;
        double gamesInSeconds = 0;

        string command = Console.ReadLine();
        
        while (command != "Quit")
        {
            int minutes = int.Parse(command.Substring(0, 2));
            int seconds = int.Parse(command.Substring(3, 2));
            
            gamesInSeconds += (minutes * 60) + seconds;
            countOfGames++;
            
            command = Console.ReadLine();
        }

        double gameAverageTime = Math.Ceiling((gamesInSeconds / countOfGames));
        string star = "";

        if (gameAverageTime < 720)
        {
            star = "Gold";
        } 
        else if (gameAverageTime >= 720 && gameAverageTime <= 1440)
        {
            star = "Silver";
        }
        else if (gameAverageTime > 1440)
        {
            star = "Bronze";
        }

        Console.WriteLine("{0} Star", star);
        Console.WriteLine("Games - {0} \\ Average seconds - {1}", countOfGames, gameAverageTime);
    }
}

