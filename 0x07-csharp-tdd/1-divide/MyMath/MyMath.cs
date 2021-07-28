using System;

namespace MyMath
{
    ///<summary>Class that has method to divide all elements of a matrix</summary>
    public class Matrix
    {
        ///<summary>Returns a new matrix containing divideded elements</summary>
        ///<param name="matrix">Matrix to divide elements of</param>
        ///<param name="num">Number to divide matrix by. Cannot be 0.</param>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
                return (null);
            int[,] quotientArray = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int x = 0; x < matrix.GetLength(0); x++)
                for (int y = 0; y < matrix.GetLength(1); y++)
                    quotientArray[x,y] = matrix[x,y] / num;

            return (quotientArray);
        }
    }
}
