﻿using System;
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
            switch (threadCount)
            {
                case "2":
                    // Создать поток.
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what you want...you get 1 thread.");
                    goto case "1";
            }
            // выполнить некоторую дополнительную работу.
            Console.WriteLine("I'm busy! Work on main thread...");
        }
    }
}
