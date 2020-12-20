using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            // etap 1 - wzór z gwiazdek
            // etap 2 - podmiana gwiazdek na liczby

            Console.WriteLine("Podaj bok trójkąta: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // i - numer wiersza
            {

                for (int j = 0; j <= i; j++) // - numer kolumny
                {
                    Console.Write("{0,4} ", (j+1)*(i+1));
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
