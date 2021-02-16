using System;
using lib;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Max_Consecutive_Ones();
        }

        static void Max_Consecutive_Ones()
        {
            var A = new int[7] { 1, 1, 1, 1, 0, 1, 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
        }
    }
}
