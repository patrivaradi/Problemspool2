using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, element, min=0,max=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                element = rnd.Next(0, n);
                Console.Write(element + " ");
                
                if (element < min)
                    min=element;
                if (element > max)
                    max = element;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa de {n} numere cel mai mic element este {min}, si cel mai mare elemente este {max}.");
            Console.ReadKey();
        }
    }
}
