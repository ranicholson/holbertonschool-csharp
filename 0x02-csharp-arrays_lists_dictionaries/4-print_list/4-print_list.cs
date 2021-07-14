using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }
            List<int> integerList = new List<int>();
            for (int x = 0; x < size; x++)
            {
                integerList.Add(x);
            }
            Console.WriteLine(string.Join(" ", integerList));
            return (integerList);
        }
    }
