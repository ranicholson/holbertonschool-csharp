using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList.Contains(value) == false)
        {
            return (-1);
        }
        int listIndex = 0;
        foreach (int storedValue in myLList)
        {
            if (storedValue == value)
            {
                return (listIndex);
            }
            listIndex++;
        }
        return (-1);
    }
}
