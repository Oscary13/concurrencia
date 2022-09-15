using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace Concurrencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(sumar);
            Thread t2 = new Thread(restar);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        public static long uno = 0;
        public static long dato = 1000000;

        public static void sumar()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine("Suma: "+uno++);
            }
            
        }

        public static void restar()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine("Resta: "+ uno--);

            }

        }
        


    }
}
