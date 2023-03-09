using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    class MultiThreading
    {
        public void Display() { 
        lock(this){
            {
                    Console.Write("[CSharp is an ");
                    Thread.Sleep(3000);
                    Console.WriteLine("object oriented language]");
            }
          }
        }
        public static void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i <= 1000000000; i++)
                Count++;
            Console.WriteLine("IncrementCounter1: " + Count);
        }
        public static void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i <= 1000000000; i++)
                Count++;
            Console.WriteLine("IncrementCounter2: " + Count);
        }
        static void Main()
        {
            ParameterizedThreadStart obj3 = delegate (object obj) { Console.WriteLine("Delegate i am"); };
            Thread t = new Thread(obj3);
            t.Start();
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);
            t2.Priority = ThreadPriority.Highest;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            t1.Start(); t2.Start();
            t1.Join(); t2.Join();
            sw.Stop();
            Console.WriteLine("multi thread time " + sw.ElapsedMilliseconds);

            Stopwatch sw2 = Stopwatch.StartNew();
            sw2.Start();
            IncrementCounter1();
            IncrementCounter2();
            sw2.Stop();
            Console.WriteLine("single thread time " + sw2.ElapsedMilliseconds);

            

            MultiThreading obj = new MultiThreading();
            Thread t3 = new Thread(obj.Display);
            Thread t4 = new Thread(obj.Display);
            Thread t5 = new Thread(obj.Display);
            t3.Start();t4.Start();t5.Start();

            Console.ReadLine();
        }
    }
}
