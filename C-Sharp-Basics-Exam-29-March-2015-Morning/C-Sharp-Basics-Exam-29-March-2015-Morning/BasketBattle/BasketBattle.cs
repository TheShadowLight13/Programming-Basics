using System;

class BasketBattle
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = (firstPlayer == "Simeon") ? "Nakov" : "Simeon";
        string playerTempVar = "";
        int rounds = int.Parse(Console.ReadLine());

        int firstPlayerPoints = 0;
        int secondPlayerPoints = 0;
        int pointsTempVar = 0;

        for (int i = 0; i < rounds; i++)
        {
            int pointsToScore = int.Parse(Console.ReadLine());
            bool isSuccessful = (Console.ReadLine() == "success") ? true : false;

            if ((firstPlayerPoints + pointsToScore == 500) && isSuccessful)
            {
                Console.WriteLine(firstPlayer);
                Console.WriteLine(i + 1);
                Console.WriteLine(secondPlayerPoints);
                return;
            }

            if (isSuccessful && (firstPlayerPoints + pointsToScore) < 500)
            {
                firstPlayerPoints += pointsToScore;
            }

            pointsToScore = int.Parse(Console.ReadLine());
            isSuccessful = (Console.ReadLine() == "success") ? true : false;

            if ((secondPlayerPoints + pointsToScore == 500) && isSuccessful)
            {
                Console.WriteLine(secondPlayer);
                Console.WriteLine(i + 1);
                Console.WriteLine(firstPlayerPoints);
                return;
            }

            if (isSuccessful && (secondPlayerPoints + pointsToScore) < 500)
            {
                secondPlayerPoints += pointsToScore;
            }

            playerTempVar = firstPlayer;
            firstPlayer = secondPlayer;
            secondPlayer = playerTempVar;

            pointsTempVar = firstPlayerPoints;
            firstPlayerPoints = secondPlayerPoints;
            secondPlayerPoints = pointsTempVar;
        }

        if (firstPlayerPoints == secondPlayerPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(firstPlayerPoints);
        }
        else if (firstPlayerPoints > secondPlayerPoints)
        {
            Console.WriteLine(firstPlayer);
            Console.WriteLine(firstPlayerPoints - secondPlayerPoints);
        }
        else if (secondPlayerPoints > firstPlayerPoints)
        {
            Console.WriteLine(secondPlayer);
            Console.WriteLine(secondPlayerPoints - firstPlayerPoints);
        }
    }
}

