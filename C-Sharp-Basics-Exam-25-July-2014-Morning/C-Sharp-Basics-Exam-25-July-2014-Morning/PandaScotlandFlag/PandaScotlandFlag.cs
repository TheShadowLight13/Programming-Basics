using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char firstAlphabet = 'A';
        char secondAlphabet = 'B';

        int dsNumber = n - 2;
        int tilde = 0;
        int dash = 0;
        int upperSide = (n / 2) + 1;
        int lowerSide = n - upperSide;

        for (int i = 0; i < upperSide ; i++)
        {

            if (i == n / 2)
            {
                dash = (n - 1) / 2;
                Console.WriteLine("{0}{1}{0}", new string('-', dash), firstAlphabet);
            }
            else
            {
                
                Console.WriteLine("{0}{1}{2}{3}{0}",
                new string('~', tilde), firstAlphabet,
                new string('#', dsNumber), secondAlphabet);

                tilde++;
                dsNumber -= 2;

                firstAlphabet = (char)(firstAlphabet + 2);
                secondAlphabet = (char)(secondAlphabet + 2);

                if (firstAlphabet > 'Z')
                {
                    firstAlphabet = 'A';
                }

                if (secondAlphabet > 'Z')
                {
                    secondAlphabet = (char)(firstAlphabet + 1);
                }


            }
           
        }

        tilde = (n - 3) / 2;
        dsNumber = 1;
        firstAlphabet = (char)(firstAlphabet + 1);
        secondAlphabet = (char)(secondAlphabet + 1);
        
        for (int i = 0; i < lowerSide; i++)
        {
            Console.WriteLine("{0}{1}{2}{3}{0}",
                new string('~', tilde), firstAlphabet,
                new string('#', dsNumber), secondAlphabet);

            tilde--;
            dsNumber += 2;

            firstAlphabet = (char)(firstAlphabet + 2);
            secondAlphabet = (char)(secondAlphabet + 2);

            if (firstAlphabet > 'Z')
            {
                firstAlphabet = 'B';
            }

            if (secondAlphabet > 'Z')
            {
                secondAlphabet = 'A';
            }

        }
    }
}

