using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Podaj długość boku kwadratu: ");
            //int n = int.Parse(Console.ReadLine());

            Stopwatch stoper = new Stopwatch();

            stoper.Start();

            for (int j = 0; j < 20; j++) // numer wiersza
            {
                for (int i = 0; i < 20; i++) // i - numer kolumny
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

            stoper.Stop();

            Console.WriteLine("Czas 1: {0}", stoper.ElapsedTicks);

            string gwiazdki = "********************";

            stoper.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(gwiazdki);
            }

            stoper.Stop();

            Console.WriteLine("Czas 1: {0}", stoper.ElapsedTicks);

            Console.ReadKey();
        }
    }
}
