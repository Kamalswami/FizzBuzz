using System;
using HelperLib;

namespace ConsoleAppFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper p = new Helper();

            foreach (string s in p.FizzBuzz(1,30))
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
