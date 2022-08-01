using System;
using System.Threading;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            // Создать делегат типа Timer.
            TimerCallback timeCB = new TimerCallback(PrintTime);
            // Установить параметры таймера.
            Timer t = new Timer(timeCB, null, 0, 1000);
            Console.WriteLine("Hit key to terminate...");
            Console.ReadLine();
        }
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}",
                DateTime.Now.ToLongTimeString(),
                state.ToString());
        }
    }
}
