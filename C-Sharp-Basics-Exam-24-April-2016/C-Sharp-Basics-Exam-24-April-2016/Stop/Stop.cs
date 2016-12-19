using System;

class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = n + 1;
        int underscore = (2 * dots) - 1;

        int rowWidth = 2 * dots + underscore;
        int height = 2 * dots;

        string firstRow = 
            new string('.', dots) + new string('_', underscore) + new string('.', dots);
        Console.WriteLine(firstRow);

        dots--;
        underscore -= 2;
        
        // Print upper part of the stop sign to the label "Stop"
        for (int i = 0; i < (height - 2) / 2; i++)
        {
            Console.WriteLine("{0}//{1}\\\\{0}", 
                new string('.', dots), new string('_', underscore));

            dots--;
            underscore += 2;
        }

        // Print row with label "Stop"
        underscore = (rowWidth - 9) / 2;
        Console.WriteLine("//{0}STOP!{0}\\\\",
            new string('_', underscore));

        dots = 0;
        underscore = rowWidth - 4;
        
        // Print lower part of the stop sign to the end
        for (int i = 0; i < (height - 2) / 2; i++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}",
                new string('.', dots), new string('_', underscore));

            dots++;
            underscore -= 2;
        }
    }
}

