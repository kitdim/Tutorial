using System;

namespace Kata_True_OR_False
{
    class Program
    {
        static string boolToWord(bool word)
        {
            string bw = word.ToString();

            if (bw == "True") return bw = "Yes";
            else return bw = "No";
        }
        static void Main(string[] args)
        {
            boolToWord(true);
            boolToWord(false);
            Console.ReadKey();
        }
    }
}
