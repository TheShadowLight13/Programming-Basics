using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int normalDayPages = int.Parse(Console.ReadLine());

        if (campingDays == 30 || normalDayPages == 0)
        {
            Console.WriteLine("never");
            return;
        }
        
        int normalDays = 30 - campingDays;
        int pagesInMonth = normalDays * normalDayPages;

        int totalMonths = (int)Math.Ceiling((double)bookPages / pagesInMonth);
        int neededYears = totalMonths / 12;
        int neededMonths = totalMonths % 12;
  
        Console.WriteLine("{0} years {1} months", neededYears, neededMonths);
    }
}

