using System;
using System.Timers;
using System.Threading;

// Uppgift 1.2
namespace Uppgift_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("An error has occurred. To continue:");
            Console.WriteLine("Press Enter to return to Windows, or");
            Console.WriteLine("Press CRTL+ALT+DEL to restart your computer.");
            Console.ReadKey();
        }
    }
}