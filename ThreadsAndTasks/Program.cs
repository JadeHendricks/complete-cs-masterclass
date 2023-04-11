using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAndTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ThreadBasics();
            //ThreadStartAndEnd();
            //ThreadPoolsAndBackgroundThreads();
            JoinAndIsAlive();
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

        public static void ThreadPoolsAndBackgroundThreads()
        {
            Enumerable.Range(0, 1000).ToList().ForEach(f =>
            {
                //ThreadPool are used to run specific work items
                //The will wait until the next thread is done/has memory before starting another one
                //if there is memory the threadpool will use it or it won't if not needed
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });
            });
        }
    
        public static void JoinAndIsAlive()
        {
            Console.WriteLine("Main Thread started");
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);

            //start the threads
            thread1.Start();
            thread2.Start();

            //joining threads
            //joining thread 1 && 2 with the  main thread - blocks the main thread for that time
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done");
            }
            else
            {
                Console.WriteLine("Thread1Function was't done in 1 second");
            }
            thread2.Join();
            Console.WriteLine("Thread2Function done");

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread 1 is still doing stuff");
            }
            else
            {
                Console.WriteLine("Thread 1 is done");
            }

            Console.WriteLine("Main Thread ended");
        }

        //to be used by JoinAndIsAlive()
        public static void Thread1Function()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function started");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
