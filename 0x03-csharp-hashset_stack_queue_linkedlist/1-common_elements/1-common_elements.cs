using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            HashSet<int> sortedCommonElements = new HashSet<int>(list1);
            sortedCommonElements.IntersectWith(list2);
            List<int> returnList = new List<int>();
            foreach (int item in sortedCommonElements)
            {
                returnList.Add(item);
            }
            return (returnList);
        }
    }
