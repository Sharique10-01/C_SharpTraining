using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<List<int[]>> meterReadings = new List<List<int[]>>()
        {
            new List<int[]>()
            {
                new int[] {10,20,30},
                new int[] {15,25,35},
                new int[] {12,22,32},
                new int[] {18,28,38},
                new int[] {14,24,34},
                new int[] {16,26,36},
                new int[] {11,21,31}
            }
        };

        Dictionary<string, Dictionary<string, List<int[]>>> areaReadings =
            new Dictionary<string, Dictionary<string, List<int[]>>>()
        {
            { "Area1", new Dictionary<string, List<int[]>>()
                {
                    { "House1", new List<int[]> {
                        new int[] {10,20,30}, new int[] {15,25,35}, new int[] {12,22,32},
                        new int[] {18,28,38}, new int[] {14,24,34}, new int[] {16,26,36}, new int[] {11,21,31}
                    }},
                    { "House2", new List<int[]> {
                        new int[] {20,30,40}, new int[] {25,35,45}, new int[] {22,32,42},
                        new int[] {28,38,48}, new int[] {24,34,44}, new int[] {26,36,46}, new int[] {21,31,41}
                    }}
                }
            }
        };

        Dictionary<string, List<string>> areaMeters = new Dictionary<string, List<string>>()
        {
            { "Area1", new List<string> { "Meter1", "Meter2", "Meter3" } },
            { "Area2", new List<string> { "Meter4", "Meter5" } }
        };

        List<Dictionary<string, string>> complaints = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                { "HouseNumber", "House1" },
                { "Issue", "Power Surge" },
                { "Date", "2025-08-30" }
            },
            new Dictionary<string, string>()
            {
                { "HouseNumber", "House2" },
                { "Issue", "Meter Fault" },
                { "Date", "2025-08-31" }
            }
        };

        Console.WriteLine("Night reading of Day 3 for Meter1: " + meterReadings[0][2][2]);

        Console.WriteLine("All readings for House1:");
        foreach (var day in areaReadings["Area1"]["House1"])
            Console.WriteLine(string.Join(", ", day));

        Console.WriteLine("All meters in Area1: " + string.Join(", ", areaMeters["Area1"]));

        Console.WriteLine("All complaints:");
        foreach (var complaint in complaints)
            Console.WriteLine($"House: {complaint["HouseNumber"]}, Issue: {complaint["Issue"]}, Date: {complaint["Date"]}");
    }
}
