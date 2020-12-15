using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static int counter;

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(AddTwo);
            Thread thread2 = new Thread(SubtractOne);

            thread1.Start();
            thread2.Start();

            Console.ReadLine();
        }

        static void AddTwo()
        {
            while(true)
            {
                lock ((object)counter)
                {
                    counter += 2;
                    Console.WriteLine(counter);

                }
                Thread.Sleep(1000);
            }
        }

        static void SubtractOne()
        {
            while(true)
            {
                lock ((object)counter)
                {
                    counter += -1;
                    Console.WriteLine(counter);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
