using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave2
{
    class Program
    {
        static object locker = new object();
        static int counter;

        static void Main(string[] args)
        {
  
                Thread thread1 = new Thread(PrintStars);
                Thread thread2 = new Thread(PrintOctothorp);

                thread1.Start();
                thread2.Start();

                Console.ReadKey();
        }

        static void PrintStars()
        {
            while (true)
            {
                lock (locker)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write("*");
                    }
                    counter += 60;
                    Console.WriteLine(" {0}", counter);
                    Thread.Sleep(5);
                }
            }
        }

        static void PrintOctothorp()
        {
            while (true)
            {
                lock (locker)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine(" {0}", counter);
                    Thread.Sleep(5);
                }
            }
        }
    }
}
