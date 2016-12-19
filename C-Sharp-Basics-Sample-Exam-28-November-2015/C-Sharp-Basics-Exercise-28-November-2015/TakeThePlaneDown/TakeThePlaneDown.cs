using System;

class TakeThePlaneDown
{
    static void Main()
    {
        int headquarterX = int.Parse(Console.ReadLine());
        int headquarterY = int.Parse(Console.ReadLine());
        int borderDistance = int.Parse(Console.ReadLine());
        int fightersApproaching = int.Parse(Console.ReadLine());

        for (int i = 0; i < fightersApproaching; i++)
        {
            int fighterXCoordinate = int.Parse(Console.ReadLine());
            int fighterYCoordinate = int.Parse(Console.ReadLine());

            bool isFighterInCircle = false;
            
            //
            // Check in I quadrant
            if (fighterXCoordinate >= headquarterX && 
                fighterXCoordinate <= headquarterX + borderDistance)
            {
                if (fighterYCoordinate >= headquarterY && 
                fighterYCoordinate <= headquarterY + borderDistance)
                {
                    isFighterInCircle = true;
                }                
            }
            //
            // Check in II quadrant
            if (fighterXCoordinate <= headquarterX &&
                fighterXCoordinate >= headquarterX - borderDistance)
            {
                if (fighterYCoordinate >= headquarterY &&
                    fighterYCoordinate <= headquarterY + borderDistance)
                {
                    isFighterInCircle = true;
                }
            }
            //
            // Check in III quadrant
            if (fighterXCoordinate <= headquarterX &&
                fighterXCoordinate >= headquarterX - borderDistance)
            {
                if (fighterYCoordinate <= headquarterY &&
                    fighterYCoordinate >= headquarterY - borderDistance)
                {
                    isFighterInCircle = true;
                }
            }
            //
            // Check in IV quadrant
            if (fighterXCoordinate >= headquarterX &&
                fighterXCoordinate <= headquarterX + borderDistance)
            {
                if (fighterYCoordinate <= headquarterY &&
                    fighterYCoordinate >= headquarterY - borderDistance)
                {
                    isFighterInCircle = true;
                }
            }

            if (isFighterInCircle)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", 
                    fighterXCoordinate, fighterYCoordinate);
            }
        }
    }
}

