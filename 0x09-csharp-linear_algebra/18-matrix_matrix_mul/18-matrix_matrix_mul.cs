﻿using System;


/// <summary>Class containing matrix math</summary>
class MatrixMath
{
    /// <summary>Multiplies matrices and returns new matrix with result</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] prodMatrix;

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return (new double [,] {{-1}});

        prodMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix2.GetLength(1); y++)
            {
                for (int z = 0; z < matrix1.GetLength(1); z++)
                    prodMatrix[x, y] += matrix1[x, z] * matrix2[z, y];
            }
        }
        return (prodMatrix);
    }
}
