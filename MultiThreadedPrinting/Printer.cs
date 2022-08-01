using System;
using System.Threading;

namespace MultiThreadedPrinting
{
    public class Printer
    {
        // Маркер блокировки.
        private object threadLock = new object();
        public void PrintNumbers()
        {
            // Использовать маркер блокировки.
            lock (threadLock)
            {
                // Вывести информацию о потоке.
                Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
                // Вывести числа.
                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(2));
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
