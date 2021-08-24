using System;


/// <summary>Class with matrix math</summary>
class MatrixMath
{
    /// <summary>Method to multiply matrix and scalar. Returns resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] prodMatrix;

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.Length != matrix2.Length || matrix1.GetLength(0) < 2)
            return (new double [,] {{-1}});

        if (matrix1.GetLength(0) == 2)
            prodMatrix  = new double[2,2];
        else
            prodMatrix = new double[3,3];

        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix1.GetLength(0); y++)
                prodMatrix[x, y] = matrix1[x, y] * scalar;
        }

        return (prodMatrix);
    }
}
