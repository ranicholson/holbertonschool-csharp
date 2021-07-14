using System;

    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int dimensionone = myMatrix.GetLength(0);
            int dimensiontwo = myMatrix.GetLength(1);
            int[,] newSquareMatrix = new int[dimensionone, dimensiontwo];
            for (int x = 0; x < dimensionone; x++)
            {
                for (int y = 0; y < dimensiontwo; y++)
                {
                    newSquareMatrix[x,y] = myMatrix[x,y] * myMatrix[x,y];
                }
            }
            return (newSquareMatrix);
        }
    }
