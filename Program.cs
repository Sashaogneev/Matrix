using System;
using System.Threading;

namespace first1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wake up, Neo...");

            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("The Matrix has you...");
            
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Follow the white rabbit.");
            
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Knock, knock, Neo.");

            Thread.Sleep(3000);
            Console.Clear();
        }
    } 
        
}





