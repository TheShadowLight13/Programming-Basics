using System;

class Operations
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        char mathOperator = char.Parse(Console.ReadLine());

        double amount = 0;

        if (mathOperator.Equals('+') || mathOperator.Equals('-') || mathOperator.Equals('*'))
        {
            string evenOrOdd = "";

            if (mathOperator.Equals('+'))
            {
                amount = firstNumber + secondNumber;
            }
            else if (mathOperator.Equals('-'))
            {
                amount = firstNumber - secondNumber;
            }
            else
            {
                amount = firstNumber * secondNumber;
            }

            evenOrOdd = (amount % 2 == 0) ? "even" : "odd";

            Console.WriteLine("{0} {1} {2} = {3} - {4}", 
                firstNumber, mathOperator, secondNumber, amount, evenOrOdd);
        }
        else if (mathOperator.Equals('/'))
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                return;
            }

            amount = (double)firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2:F2}", firstNumber, secondNumber, amount);
        }
        else if (mathOperator.Equals('%'))
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                return;
            }

            amount = firstNumber % secondNumber;
            Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, amount);
        }
    }
}

