using System;
using System.Threading;

/*
 * @author bas
 */

namespace DelegatesAndEvents02AsynchronousTimer
{
    class AsyncTimer
    {
        private Action<string> action;
        private int ticks;
        private int t; // time interval in mlsecs

        public AsyncTimer(Action<string> a, int ticks, int t)
        {
            this.action = a;
            this.ticks = ticks;
            this.t = t;
        }

        public void Run()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.t);

                if (this.action != null)
                {
                    action(this.ticks + "");
                }
                this.ticks--;
            }
        }


        public static void FirstCheck(string s)
        {
            Console.Beep();
        }

        public static void SecCheck(string s)
        {
            Console.WriteLine("works?");
        }

        static void Main(string[] args)
        {
            AsyncTimer at = new AsyncTimer(FirstCheck, 5, 1000);
            at.Run();
            AsyncTimer at1 = new AsyncTimer(SecCheck, 10, 3000);
            at1.Run();

        }
    }
}
