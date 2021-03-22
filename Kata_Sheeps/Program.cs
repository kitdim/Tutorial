using System;

namespace Kata_Sheeps
{
    class Program
    {

        /// <summary>
        /// Метод для подсчета истины 
        /// </summary>
        static int Sheps(bool[] a)/// <summary>
                                  /// Метод для подсчета истины 
                                  /// </summary>
                                  /// <param name="a"></param>
                                  /// <returns></returns>
        {
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == true) b++;
            }
            return b;
        }
        static void Main(string[] args)
        {
            var sheeps = new bool[] { true, false, true };
            Console.WriteLine(Sheps(sheeps));
            Console.ReadKey();
        }
    }
}
