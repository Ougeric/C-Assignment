using System;

namespace ToplitzMatrixChecker
{
    class MatrixChecker
    {
        public static bool CheckIsToeplitzMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            if (rows == 0) return false;
            int cols = matrix[0].Length;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j] != matrix[i + 1][j + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 1, 2, 3 },
                new int[] { 9, 5, 1, 2 }
            };
            Console.WriteLine($"Matrix is Toplitz Matrix: {CheckIsToeplitzMatrix(matrix)}");
        }
    }
}