using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. 
        /// Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, element;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pentru ce numar vreti sa aflati pozitia : ");
            int a = int.Parse(Console.ReadLine());
            int pozitia = 0,este=0;
            for (int i = 0; i <= n; i++)
            {
                element = rnd.Next(0, 5);
                Console.Write(element + " ");
                if (element == a)
                {
                    este = 1;                           //TODO daca se afla elementul de mai multe ori in secventa, sa afiseze toate pozitiile
                    pozitia = i;
                }                                                 
            }
            Console.WriteLine();
            if (este == 1)
                Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitia}");
            else 
                Console.WriteLine("-1");
            Console.ReadKey();
        }
    }
}
