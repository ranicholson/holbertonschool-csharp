using System;


/// <summary>Class containing matrix math</summary>
class MatrixMath
{
    /// <summary>Method that shears a 2D matrix by the providedshear factor.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (direction == 'x' && matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            return (new double[,] {{matrix[0, 0] + (factor * matrix[0, 1]), matrix[0, 1]}, {matrix[1, 0] + (factor * matrix[1, 1]), matrix[1 ,1]}});

        if (direction == 'y' && matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            return (new double[,] {{matrix[0, 0], matrix[0, 1] + (factor * matrix[0, 0])}, {matrix[1, 0], matrix[1, 1] + (factor * matrix[1, 0])}});

        return (new double[,] {{-1}});
    }
}
