using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, element,pare=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n;  i++)
            {
                element = rnd.Next(-50,50);
                Console.Write(element+" ");
                if (element % 2 == 0)
                    pare++;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa de {n} numere sunt {pare} elemente pare.");
            Console.ReadKey();
        }
    }
}
