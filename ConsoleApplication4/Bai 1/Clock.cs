using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4.Bai_1
{
    class Clock
    {
        private Thread t;
        private bool state = false;

        

        internal bool IsRunning
        {
            get 
            {
                return state;    
            }
        } 

        internal void start()
        {
            t = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread 1 "+DateTime.Now);
                }
            }));
            t.Start();
            state = t.IsAlive;
        }

        internal void start(int count)
        {
            Thread t2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Thread 2 "+DateTime.Now);
                    Thread.Sleep(1000);
                }
            }));
            t2.Start();
        }

        internal void stop()
        {
            t.Abort();
            state = t.IsAlive;
            Console.WriteLine("Thread ket thuc");
        }
    }
}
