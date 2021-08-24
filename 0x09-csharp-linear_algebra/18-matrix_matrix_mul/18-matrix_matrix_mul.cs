using System;


/// <summary>Class containing matrix math</summary>
class MatrixMath
{
    /// <summary>Multiplies matrices and returns new matrix with result</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] prodMatrix;

        prodMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix1.GetLength(0); y++)
            {
                for (int z = 0; z < matrix1.GetLength(0); z++)
                    prodMatrix[x, y] += matrix1[x, z] * matrix2[z, y];
            }
        }
        return (sumMatrix);
    }
}
