﻿using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Factorial(n);
            Console.WriteLine(result);
        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}