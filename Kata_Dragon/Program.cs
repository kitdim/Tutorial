using System;

namespace Kata_Dragon
{
    class Program
    {
        /// <summary>
        /// Метод который проверяет хватит ли пуль на дракона.
        /// 1 дракон = 2 пули
        /// </summary>
        /// <param name="bullets"></param>
        /// <param name="dragon"></param>
        /// <returns></returns>
        static bool KillOr(int bullets, int dragon)
        {
            dragon *= 2;
            int hero = bullets - dragon;

            return hero >= 0 ? true : false;
        }
        static void Main(string[] args)
        {
            Console.Write("Cколько пуль?: "); int bullets = int.Parse(Console.ReadLine());
            Console.Write("Cколько драконов?: "); int dragon = int.Parse(Console.ReadLine());          
            Console.WriteLine($"{KillOr(bullets, dragon)}");
            Console.ReadKey();

        }
    }
}
