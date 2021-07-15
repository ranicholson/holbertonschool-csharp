using System;
using System.Collections.Generic;

    class List
    {
        public static int Sum(List<int> myList)
        {
            HashSet<int> uniqueInts = new HashSet<int>(myList);
            int uniqueSum = 0;
            foreach (int x in uniqueInts)
            {
                uniqueSum += x;
            }
            return (uniqueSum);
        }
    }
