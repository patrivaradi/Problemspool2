using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
        /// </summary>        
        static void Main(string[] args)
        {
            int n, element, negative = 0, zero = 0, pozitive = 0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                element = rnd.Next(-5, 5);
                Console.Write(element+" ");
                if (element > 0)
                    pozitive++;
                if (element < 0)
                    negative++;
                if (element == 0)
                    zero++;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa de {n} numere sunt {negative} elemente negative, {zero} de zero si {pozitive} elemente pozitive.");
            Console.ReadKey();
        }
    }
}
