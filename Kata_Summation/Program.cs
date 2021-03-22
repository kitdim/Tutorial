using System;

namespace Kata_Summation
{
    class Program
    {
        /// <summary>
        /// Метод для подсчета суммы
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int summation(int num)
        {
            var sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;

            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(summation(100)); Console.ReadKey();
        }
    }
}
