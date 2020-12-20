using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok trójkąta: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n - 1; i >= 0; i--) // i - ilość spacji w kolejnych wierszach
            {

                if (i == n - 1 || i == n - 2 || i == 0)
                {



                    // wydruk spacji
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    // wydruk krzyżyków
                    for (int k = 0; k < n - i; k++)
                    {
                        Console.Write("X");
                    }
                    // przejście do nowej linii
                    Console.WriteLine();
                }

                else {

                    // wydruk spacji
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("X");
                    // wydruk spacji
                    for (int k = 0; k < n - i - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("X");

                    // przejście do nowej linii
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
