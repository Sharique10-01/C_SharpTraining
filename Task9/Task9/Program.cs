using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "favorites.txt";
        using (StreamWriter sw = new StreamWriter(path))
        {
            for (int i = 0; i < 5; i++)
                sw.WriteLine(Console.ReadLine());
        }
        string[] colors = File.ReadAllLines(path);
        foreach (string color in colors)
            Console.WriteLine(color);
    }
}
