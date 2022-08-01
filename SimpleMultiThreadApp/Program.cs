using System;
using System.Threading;

namespace SimpleMultiThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing Thread App *****\n");
            Console.Write("Do you want [1] or [2] threads? ");
            // Запрос количества потоков.
            string threadCount = Console.ReadLine();
            // Назначить имя текущему потоку.
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            // Вывести информацию о потоке.
            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);
            // Создать рабочий класс.
            Printer p = new Printer();
        }
    }
}
