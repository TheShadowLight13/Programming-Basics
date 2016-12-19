using System;

class LocalElections
{
    static void Main()
    {
        int candidatesNumber = int.Parse(Console.ReadLine());
        int electorVote = int.Parse(Console.ReadLine());
        char votingSymbol = char.Parse(Console.ReadLine().ToUpper());

        int width = 13;

        int dots = 3;
        int middleDots = 5;
        int dash = 5;

        for (int cell = 1; cell <= candidatesNumber; cell++)
        {
            Console.WriteLine(new string('.', width));

            Console.WriteLine("{0}+{1}+{0}",
                new string('.', dots),
                new string('-', dash));

            if (votingSymbol.Equals('X') && cell == electorVote)
            {
                Console.WriteLine("{0}|.\\./.|{0}", new string('.', dots));

                Console.WriteLine("{0}.|..{1}..|{2}", cell.ToString().PadLeft(2, '0'),
                    votingSymbol, new string('.', dots));

                Console.WriteLine("{0}|./.\\.|{0}", new string('.', dots));
            }
            else if (votingSymbol.Equals('V') && cell == electorVote)
            {
                Console.WriteLine("{0}|\\.../|{0}", new string('.', dots));

                Console.WriteLine("{0}.|.\\./.|{1}", cell.ToString().PadLeft(2, '0'),
                    new string('.', dots));

                Console.WriteLine("{0}|..{1}..|{0}", new string('.', dots), votingSymbol);
            }
            else
            {
                Console.WriteLine("{0}|{1}|{0}",
                new string('.', dots),
                new string('.', middleDots));

                Console.WriteLine("{0}.|{1}|{2}", cell.ToString().PadLeft(2, '0'),
                new string('.', middleDots),
                new string('.', dots));

                Console.WriteLine("{0}|{1}|{0}",
                new string('.', dots),
                new string('.', middleDots));
            }

            Console.WriteLine("{0}+{1}+{0}",
                new string('.', dots),
                new string('-', dash));
        }

        Console.WriteLine(new string('.', width));
    }
}

