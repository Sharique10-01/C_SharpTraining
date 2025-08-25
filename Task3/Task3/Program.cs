using System;

class SmartMeterStatistics
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    static void Main()
    {
        int[] units = new int[7];  // Array for 7 days

        Console.WriteLine("Enter units consumed for each day (Mon-Sun):");

        // Input loop
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"{ (Days)i} "); // {(Days)i} 
            units[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = 0;
        int maxUnits = units[0];
        int maxDayIndex = 0;

        for (int i = 0; i < 7; i++)
        {
            total += units[i];
            if (units[i] > maxUnits)
            {
                maxUnits = units[i];
                maxDayIndex = i;
            }
        }

        double average = (double)total / 7;

        Console.WriteLine($"\nTotal units: {total}");
        Console.WriteLine($"Average units/day: {average:F2}");
        Console.WriteLine($"Highest consumption: {(Days)maxDayIndex} ({maxUnits} units)");
    }
}
