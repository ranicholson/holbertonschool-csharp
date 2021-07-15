using System;
using System.Collections.Generic;

    class LList
    {
        public static int GetNode(LinkedList<int> myLList, int n)
        {
            if (myLList.Count <= n)
            {
                return (0);
            }
            int nodeIndex = 0;
            foreach (int storedValue in myLList)
            {
                if (nodeIndex == n)
                {
                    return (storedValue);
                }
                nodeIndex++;
            }
            return (0);
        }
    }
