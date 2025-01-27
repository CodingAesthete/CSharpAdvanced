﻿using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            int sum = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
