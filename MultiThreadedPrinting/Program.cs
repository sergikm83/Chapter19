using System;
using System.Threading;

namespace MultiThreadedPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synchronizing Threads *****\n");
            Printer p = new Printer();
            // Создать 10 потоков, которые указывают на один
            // и тот же метод того же самого объекта.
            Thread[] threads = new Thread[30];
            for(int i=0;i<threads.Length;i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread # {i}"
                };
            }
            // Теперь запустим их все.
            foreach (Thread t in threads)
                t.Start();
        }
    }
}
