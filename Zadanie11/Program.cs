using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok trójkąta: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n-1; i >= 0; i--) // i - ilość spacji w kolejnych wierszach
            {
                // wydruk spacji
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // wydruk krzyżyków
                for (int k = 0; k < n-i; k++)
                {
                    Console.Write("X");
                }
                // przejście do nowej linii
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
