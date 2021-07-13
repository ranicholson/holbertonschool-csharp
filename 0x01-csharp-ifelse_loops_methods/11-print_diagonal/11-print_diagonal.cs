using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine();
            }
            else
            {
                for (int space = 0; space <= length; space++)
                {
                    string spaces = new String(' ', space);
                    Console.WriteLine("{0}\\", spaces);
                }
            }
        }
    }
