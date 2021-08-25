using System;


/// <summary>Class containint matrix math</summary>
class MatrixMath
{
    /// <summary>Rotates a 2d matrix by given angle(in radians) and returns matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] newMatrix = new double[2, 2];
        double[,] rotationForm = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double [,] {{-1}});

        for (int x = 0; x < 2; x ++)
        {
            for (int y= 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                    newMatrix[x, y] += Math.Round(matrix[x, z] * rotationForm[z, y], 2);
            }
        }

        return (newMatrix);
    }
}
