using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }
            else
            {
                int[] newArray = new int[size];
                if (size == 0)
            {
                Console.WriteLine();
                return (newArray);
            }
                for (int x = 0; x < size; x++)
                {
                    newArray[x] = x;
                    if (x == size - 1)
                    {
                        Console.WriteLine(x);
                        break;
                    }
                    Console.Write("{0} ", x);
                }
                return (newArray);
            }
        }
    }
