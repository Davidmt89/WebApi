using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadTest
{
    public class Alpha
    {
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha. Beta is running in its own thread");
            }
        }
    }

    public class Simple
    {
        public static int Main()
        {
            Console.WriteLine("Thread Start/Stop/Join Sample");

            Alpha oAlpha = new Alpha();
            Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));

            oThread.Start();

            while (!oThread.IsAlive)
            {
                Console.WriteLine("Thread running");
            }

            Thread.Sleep(3000);
            oThread.Abort();
            oThread.Join();

            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");

            try
            {
                Console.WriteLine("Try to restart the Alpha. Beta thread");
                oThread.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStatException trying to restart Alpha.Beta");
                Console.WriteLine("Excpected since aborted threads cannot be restarted.");
            }

            Console.ReadLine();

            return 0;
        }
    }
}
