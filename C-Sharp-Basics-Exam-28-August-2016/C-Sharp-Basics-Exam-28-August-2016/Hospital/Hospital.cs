using System;

class Hospital
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());

        int doctors = 7;
        int treatedPatients = 0;
        int untreatedPatients = 0;

        for (int currentDay = 1; currentDay <= days; currentDay++)
        {
            int currentPatients = int.Parse(Console.ReadLine());

            if (currentDay % 3 == 0 && untreatedPatients > treatedPatients)
            {
                doctors++;
            }

            if (currentPatients <= doctors)
            {
                treatedPatients += currentPatients;
            }
            else
            {
                treatedPatients += doctors;
                untreatedPatients += currentPatients - doctors;
            }
        }

        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);

    }
}

