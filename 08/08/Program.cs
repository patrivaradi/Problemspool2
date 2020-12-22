using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se 
        /// construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti n, pentru al determina al n-lea numar din sirul lui Fibonacci : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este = {Fibonacci(n-1)}");
            Console.ReadKey();
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else 
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
