using System;

class StopNumber
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        int stopNum = int.Parse(Console.ReadLine());

        for (int currentNum = endNum; currentNum >= startNum; currentNum--)
        {
            if (currentNum % 2 == 0 && currentNum % 3 == 0)
            {
                if (currentNum == stopNum)
                {
                    return;
                }

                Console.Write("{0} ", currentNum);
            }
        }
    }
}

