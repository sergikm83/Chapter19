using System;
using System.Threading;

namespace AsyncDelegate
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine("***** Async Delegate Invocation *****");
            // Вывести идентификатор выполняющегося потока.
            Console.WriteLine("Main() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            // Вызвать Add() во вторичном потоке.
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult ar = b.BeginInvoke(10, 10, null, null);
            // Выполнить другую работу в первичном потоке...
            Console.WriteLine("Doing more work in Main()");
            // По готовности получить результат выполнение метода Add().
            int answer = b.EndInvoke(ar);
            Console.WriteLine("10 + 10 is {0}.", answer);
        }
        static int Add(int x, int y)
        {
            // Вывести идентификатор выполняющегося потока.
            Console.WriteLine("Add() invoked thread {0}.", Thread.CurrentThread.ManagedThreadId);
            // Сделать паузу для моделирования длительной операции.
            Thread.Sleep(5000);
            return x + y;
        }
        static void AddComplete(IAsyncResult ar)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Tour addition is complete");
            isDone = true;
        }
    }
}
