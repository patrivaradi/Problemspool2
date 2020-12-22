using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        static void Main(string[] args)
        {
            int n, element, x = 0, consecutiv=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                element = rnd.Next(0, 5);
                Console.Write(element + " ");
                if (element == x)
                    consecutiv++;
                x = element;
            }
            Console.WriteLine();
            if (consecutiv == 0)
                Console.WriteLine("Nu sunt elemente consecutiv egale in secventa.");
            else
                Console.WriteLine($"Sunt {consecutiv} elemente consecutiv egale in secventa.");
            Console.ReadKey();
        }
    }
}
