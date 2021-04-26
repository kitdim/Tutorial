using System;
using System.Linq;

namespace Kata_One_Two
{
    class Program
    {
        /// <summary>
        /// Метод для поиска двух минимальных чисел в массиве
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int SumTwoMin(int[] ar)
        {
            int OneMin = ar.Min();
            int TwoMin = ar[1];

            for (int i = 0; i < ar.Length; i++)
            {
                if (TwoMin > ar[i] && ar[i] != OneMin) TwoMin = ar[i];
            }

            return OneMin + TwoMin;
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 0, 4, 5 };
            int sum = SumTwoMin(ar);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
