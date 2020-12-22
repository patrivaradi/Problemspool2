using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, element;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                element = rnd.Next(0,10);
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
