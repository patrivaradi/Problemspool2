using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        /// Se considera ca primul element din secventa este pe pozitia 0.
        /// </summary>
        static void Main(string[] args)
        {
            int n, element;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());            
            int acelasiloc = 0;
            for (int i = 0; i <= n; i++)
            {
                element = rnd.Next(0, n);
                Console.Write(element + " ");
                if (element == i)
                {
                    acelasiloc++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa de {n} numere se afla {acelasiloc} numere sunt egale cu pozitia pe care apar in secventa.");
            Console.ReadKey();
        }
    }
}
