using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array != null)
            {
                for (int x = array.Length - 1; x >= 0; x--)
                {
                    if (x == 0)
                    {
                        Console.Write(array[x]);
                        break;
                    }
                    Console.Write("{0} ", array[x]);
                    }
            }
            Console.WriteLine();
        }
    }
