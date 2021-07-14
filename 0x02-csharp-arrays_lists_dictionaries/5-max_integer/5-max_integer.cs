using System;
using System.Collections.Generic;

    class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if (myList.Count > 0)
            {
                int largestElement = myList[0];
                for (int x = 0; x < myList.Count; x++)
                {
                    if (myList[x] > largestElement)
                    {
                        largestElement = myList[x];
                    }
                }
                return (largestElement);
            }
            else
            {
                Console.WriteLine("List is empty");
                return (-1);
            }
        }
    }
