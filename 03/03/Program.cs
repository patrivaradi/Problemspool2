﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        static void Main(string[] args)
        {
            int n, element, suma=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                element = rnd.Next(-10, 10);
                Console.Write(element + " ");
                suma += element;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa de {n} numere suma elementelor este = {suma}");
            Console.ReadKey();
        }
    }
}
