﻿using System;
using System.Threading;

namespace SyncDelegateReview
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int Add(int x, int y)
        {
            // Вывести идентификатор выполняющегося потока.
            Console.WriteLine("Add() invoked thread {0}.",Thread.CurrentThread.ManagedThreadId);
            // Сделать паузу для моделирования длительной операции.
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
