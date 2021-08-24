using System;


/// <summary>Class with matrix math</summary>
class MatrixMath
{
    /// <summary>Method that adds two matrices and returns resulting matrix</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] sumMatrix;

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.Length != matrix2.Length || matrix1.Length < 2)
            return (new double [,] {{-1}});

        if (matrix1.GetLength(0) == 2)
            sumMatrix  = new double[2,2];
        else
            sumMatrix = new double[3,3];

        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix1.GetLength(0); y++)
                sumMatrix[x, y] = matrix1[x, y] + matrix2[x, y];
        }

        return (sumMatrix);
    }
}
