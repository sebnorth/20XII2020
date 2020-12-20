using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice1
{
    class Program
    {

        static bool FirstLast6(int[] tab) {

            if (tab[0] == 6 || tab[tab.Length - 1] == 6)
                return true;
            else
                return false;
        
        }

        static void Main(string[] args)
        {

            int[] tablica = { 1, 2, 6 };

            Console.WriteLine(FirstLast6(tablica));

            Console.WriteLine(FirstLast6(new int[] { 6,1,2,3}));

            Console.WriteLine(FirstLast6(new int[] { 13,6,1,2,3}));


            //Console.WriteLine("Podaj rozmiar tablicy: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] tablica = new int[n];

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    Console.WriteLine($"Podaj {i}-ty element tablicy: ");
            //    tablica[i] = int.Parse(Console.ReadLine());
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"{tablica[i]} ");
            //}

            //// Console.WriteLine(tablica);
            //Console.WriteLine();

            //foreach (int item in tablica)
            //{
            //    Console.Write($"{item} ");
            //}

            //int x;
            //Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
