using System;
using System.Linq;

namespace P03_JediGalaxy
{
    public class Startup
    {
        public static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int row = dimestions[0];
            int col = dimestions[1];

            int[,] matrix = new int[row, col];

             CreatesMatrix(row, col, matrix);

            string command = Console.ReadLine();
            long sum = 0;

            while (command != "Let the Force be with you")
            {
                int[] ivoCoordinates = command
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int[] evilCoordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int evilRow = evilCoordinates[0];
                int evilCol = evilCoordinates[1];

                EvilDstroyStars(matrix, evilRow, evilCol);

                int ivoRow = ivoCoordinates[0];
                int ivoCol = ivoCoordinates[1];

                IvoAddsStars(matrix, ref sum, ref ivoRow, ref ivoCol);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        private static void CreatesMatrix(int row, int col, int[,] matrix)
        {
            int value = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }

        private static void IvoAddsStars(int[,] matrix, ref long sum, ref int ivoRow, ref int ivoCol)
        {
            while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
            {
                if (ivoRow >= 0 && ivoRow < matrix.GetLength(0) && ivoCol >= 0 && ivoCol < matrix.GetLength(1))
                {
                    sum += matrix[ivoRow, ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }
        }

        private static void EvilDstroyStars(int[,] matrix,  int evilRow,  int evilCol)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (evilRow >= 0 && evilRow < matrix.GetLength(0) && evilCol >= 0 && evilCol < matrix.GetLength(1))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }
    }
}
