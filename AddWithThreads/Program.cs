﻿using System;
using System.Threading;

namespace AddWithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}", Thread.CurrentThread.ManagedThreadId);
            // Создать объект AddParams для передачи вторичному потоку.
            AddParams ap = new AddParams(18, 33);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            // Подождать, пока другой поток завершится.
            Thread.Sleep(500);
        }
        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);
                AddParams ap = (AddParams)data;
                Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);
            }    
        }
    }
}
