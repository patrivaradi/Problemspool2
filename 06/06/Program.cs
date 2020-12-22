using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        /// </summary>
        static void Main(string[] args)
        {
            int n, element, x=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                element = rnd.Next(0, 10);
                Console.Write(element + " ");
                if (element < x)
                {
                    Console.WriteLine("Elementele nu sunt in ordine crescatoare.");
                    break;
                }
                    x = element;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
