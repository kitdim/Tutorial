using System;

namespace Kata_Boolean
{
    class Program
    {
        /// <summary>
        /// Перевод логического значения в строку
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        static string false_true(bool b)
        {
            string TrueOrFalse;

            if (b == true) return TrueOrFalse = "True";
            else return TrueOrFalse = "False";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(false_true(true));
            Console.WriteLine(false_true(false));
            Console.ReadKey();
        }
    }
}
