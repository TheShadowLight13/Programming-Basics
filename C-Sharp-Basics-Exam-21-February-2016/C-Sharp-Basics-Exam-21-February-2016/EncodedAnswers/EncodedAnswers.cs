using System;

class EncodedAnswers
{
    static void Main()
    {
        int questions = int.Parse(Console.ReadLine());

        char[] answersArr = new char[questions];
        int aCounter = 0;
        int bCounter = 0;
        int cCounter = 0;
        int dCounter = 0;

        for (int i = 0; i < questions; i++)
        {
            long currentNum = long.Parse(Console.ReadLine());

            if (currentNum % 4 == 0)
            {
                answersArr[i] = 'a';
                aCounter++;
            }
            else if (currentNum % 4 == 1)
            {
                answersArr[i] = 'b';
                bCounter++;
            }
            else if (currentNum % 4 == 2)
            {
                answersArr[i] = 'c';
                cCounter++;
            }
            else if (currentNum % 4 == 3)
            {
                answersArr[i] = 'd';
                dCounter++;
            }
        }

        foreach (char answer in answersArr)
        {
            Console.Write("{0} ", answer);
        }

        Console.WriteLine();

        Console.WriteLine("Answer A: {0}", aCounter);
        Console.WriteLine("Answer B: {0}", bCounter);
        Console.WriteLine("Answer C: {0}", cCounter);
        Console.WriteLine("Answer D: {0}", dCounter);
    }
}

