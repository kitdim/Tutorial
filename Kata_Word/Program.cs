using System;

namespace Kata_Word
{
    class Program
    {
        public static int[] Capitals(string word)
        {
            int a = word.Length;
            int[] ar = new int[a];
            int i = 0 , b = 0;

            while (i<word.Length)
            {
                if (word[i]==word.ToUpper()[i])
                {
                  ar[b] = i;
                  b++;
                }
                i++;
            }
            return ar;

        }
        static void Main(string[] args)
        {
            string a = "SsSsS";
            Console.WriteLine(Capitals(a));
            Console.ReadKey();
        }
    }
}
