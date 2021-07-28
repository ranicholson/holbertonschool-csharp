using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary>Class to test MyMAth.Divide()</summary>
    public class Tests
    {
        [Test]
        public void dividePositive()
        {
            int[,] matrix = new int[,] {{0, 2}, {4, 6}, {8, 10}};
            int n = 1;
            int[,] quotientMatrix = Matrix.Divide(matrix, n);
            Assert.AreEqual(matrix, quotientMatrix);
        }
        [Test]
        public void divideNegative()
        {
            int[,] matrix = new int[,] {{0, 2}, {4, 6}, {8, 10}};
            int n = -1;
            int[,] quotientMatrix = Matrix.Divide(matrix, n);
            int[,] matrixResult = new int[,] {{0, -2}, {-4, -6}, {-8, -10}};
            Assert.AreEqual(matrixResult, quotientMatrix);
        }
        [Test]
        public void divideNullMatrix()
        {
            int[,] matrix = null;
            int n = 1;
            int[,] quotientMatrix = Matrix.Divide(matrix, n);
            Assert.AreEqual(null, quotientMatrix);
        }
        [Test]
        public void divideZero()
        {
            int[,] matrix = new int[,] {{0, 2}, {4, 6}, {8, 10}};
            int n = 0;
            int[,] quotientMatrix = Matrix.Divide(matrix, n);
            Assert.AreEqual(null, quotientMatrix);
        }
    }
}