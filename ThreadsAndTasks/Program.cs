using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAndTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ThreadBasics();
            ThreadStartAndEnd();
            Console.Read();
        }

        public static void ThreadBasics()
        {
            Console.WriteLine("Hello World1!");
            //this will pause our thread(program) for one second
            Thread.Sleep(1000);
            Console.WriteLine("Hello World2!");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World3!");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World4!");

            //creating a new thread and starting it
            //these will all run at the same time as they are all on different threads
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
        }

        public static void ThreadStartAndEnd()
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            });
            Console.WriteLine($"Thread number: {thread.ManagedThreadId}");
            thread.Start();

            //we use this to see if the task ewas successful or not
            var test = taskCompletionSource.Task.Result;
            Console.WriteLine("Task was done: {0}", test);
        }
    }
}
