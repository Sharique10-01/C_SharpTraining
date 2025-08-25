// See https://aka.ms/new-console-template for more information


// Task : 1 

using System;

class SmartMeter
{
    static void Main()
    {
 
        Console.Write("Enter units consumed: ");

        string input = Console.ReadLine();

        
        int units = Convert.ToInt32(input);

        int bill = 0; // Variable to store total bill

        
        if (units <= 100)
        {
            bill = units * 5;
        }
        else if (units <= 200)
        {
            bill = (100 * 5) + ((units - 100) * 7);
        }
        else
        {
            bill = (100 * 5) + (100 * 7) + ((units - 200) * 10);
        }

     
        Console.WriteLine("Total electricity bill: $" + bill);
    }
}