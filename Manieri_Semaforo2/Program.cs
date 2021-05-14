using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Manieri_Semaforo2
{
    class Program
    {
        private static int s;
        static SemaphoreSlim s1 = new SemaphoreSlim(1);
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => Procedura1());
            Thread t2 = new Thread(() => Procedura2());


            t1.Start();
            t2.Start();
            while (t1.IsAlive) { }
            while (t2.IsAlive) { }

            Console.ReadLine();

        }

        private static void Procedura1()
        {
            Console.WriteLine("Inserire primo numero intero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire primo numero intero");
            int b = int.Parse(Console.ReadLine());

            s = a + b;
            
            Console.WriteLine(a + ", " + b);
        }

        private static void Procedura2()
        {

            Random r = new Random();
            int c = r.Next(10, 99);

            Console.WriteLine(c + "" + s);
        }
    }
}
