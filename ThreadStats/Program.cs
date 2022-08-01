using System;
using System.Threading;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Primary Thread stats *****\n");
            // Получить имя текущего потока.
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";
            // Имя текущего домена приложения.
            Console.WriteLine("Name of current AppDomain: {0}",Thread.GetDomain().FriendlyName);
            // Вывести некоторую статистику о текущем потоке.
            Console.WriteLine("Thread Name: {0}", primaryThread.Name);
            Console.WriteLine("Has thread started?: {0}", primaryThread.IsAlive);
            Console.WriteLine("Priority Level: {0}", primaryThread.Priority);
            Console.WriteLine("Thread State: {0}", primaryThread.ThreadState);
        }
    }
}
