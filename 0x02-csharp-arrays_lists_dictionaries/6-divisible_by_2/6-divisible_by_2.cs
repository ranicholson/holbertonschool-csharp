using System;
using System.Collections.Generic;

    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
            List<bool> booleanList = new List<bool>();
            foreach(int number in myList)
            {
                if (number % 2 == 0)
                {
                    booleanList.Add(true);
                }
                else
                {
                    booleanList.Add(false);
                }
            }
            return (booleanList);
        }
    }
