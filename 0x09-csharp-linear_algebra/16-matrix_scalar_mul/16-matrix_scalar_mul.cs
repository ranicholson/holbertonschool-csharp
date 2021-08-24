using System;


/// <summary>Class with matrix math</summary>
class MatrixMath
{
    /// <summary>Method to multiply matrix and scalar. Returns resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] prodMatrix;

        if (matrix.GetLength(0) < 2 || matrix.GetLength(1) > 3)
            return (new double [,] {{-1}});

        if (matrix.GetLength(0) == 2)
            prodMatrix  = new double[2,2];
        else
            prodMatrix = new double[3,3];

        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
                prodMatrix[x, y] = matrix[x, y] * scalar;
        }

        return (prodMatrix);
    }
}
