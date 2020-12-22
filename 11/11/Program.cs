using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
        /// </summary>
        static void Main(string[] args)
        {
            int n, element, invers,suma=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                element = rnd.Next(-5, 5);
                Console.Write(element + " ");
                invers = element * (-1);
                suma += invers;
                    
            }
            Console.WriteLine();
            Console.WriteLine($"Suma inverselor din secventa este = {suma}");
            Console.ReadKey();
        }
    }
}
