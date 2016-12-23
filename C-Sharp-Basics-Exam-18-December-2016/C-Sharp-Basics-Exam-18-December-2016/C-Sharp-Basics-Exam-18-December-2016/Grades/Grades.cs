using System;

class Grades
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());

        int weakStudents = 0;
        int averageStudents = 0;
        int veryGoodStudents = 0;
        int excellentStudents = 0;

        decimal averageEvaluation = 0;

        for (int i = 0; i < students; i++)
        {
            decimal evaluation = decimal.Parse(Console.ReadLine());

            if (evaluation >= 2.00M && evaluation <= 2.99M)
            {
                weakStudents++;
            }
            else if (evaluation >= 3.00M && evaluation <= 3.99M)
            {
                averageStudents++;
            }
            else if (evaluation >= 4.00M && evaluation <= 4.99M)
            {
                veryGoodStudents++;
            }
            else if (evaluation >= 5.00M)
            {
                excellentStudents++;
            }

            averageEvaluation += evaluation;
        }

        averageEvaluation /= students;

        decimal weakStudentsPercent = ((decimal)weakStudents / students) * 100;
        decimal averageStudentsPercent = ((decimal)averageStudents / students) * 100;
        decimal veryGoodStudentsPercent = ((decimal)veryGoodStudents / students) * 100;
        decimal excellentStudentsPercent = ((decimal)excellentStudents / students) * 100;

        Console.WriteLine("Top students: {0:F2}%", excellentStudentsPercent);
        Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", veryGoodStudentsPercent);
        Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", averageStudentsPercent);
        Console.WriteLine("Fail: {0:F2}%", weakStudentsPercent);
        Console.WriteLine("Average: {0:F2}", averageEvaluation);
    }
}

