using System;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}",
                DateTime.Now.ToLongTimeString());
        }
    }
}
