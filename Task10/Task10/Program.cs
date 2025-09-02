using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync()
    {
        Console.WriteLine("Download Strated");
        await Task.Delay(5000);
        Console.WriteLine("Download complete!");
    }

    static async Task Main()
    {
        await DownloadFileAsync();
    }
}
