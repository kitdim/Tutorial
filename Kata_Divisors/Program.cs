using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Divisors
{
    class Program
    {
        /// <summary>
        ///  Метод подсчета делителей натуральных чисел
        /// </summary>
        /// <param натуральное число="n"></param>
        /// <returns>Количество делителей</returns>
        public static int Divisors(int n)
        {
            int a = 0;
            int b = 1;
            while (true)
            {
                if (n % b == 0) a++;
                if (n == b) break;
                b++;
            }
            return a;
        }
        static void Main(string[] args)
        {
            var n = 100;
            var b = Divisors(n);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
