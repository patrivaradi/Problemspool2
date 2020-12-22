using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
        /// </summary>
        static void Main(string[] args)
        {
            int n, a,crescator=0,descrescator=0;
            Random rnd = new Random();
            Console.Write("Introduceti cate elemente sunt in secventa: ");
            n = int.Parse(Console.ReadLine());            
            Console.WriteLine("Introduceti numerele");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a <= b)
                    crescator++;
                else if (a <= b)
                    descrescator++;
                b = a;
            }
            if (descrescator == 0)
                Console.WriteLine("Secventa este monoton crescatoare");
            else if (crescator == 0)
                Console.WriteLine("Secventa este monoton descrescatoare");
            else
                Console.WriteLine("Secventa NU este monotona");
            Console.ReadKey();
        }
    }
}
