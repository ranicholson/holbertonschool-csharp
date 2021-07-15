using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int elementCount = 0;
        foreach (int number in myLList)
        {
            elementCount++;
        }
        return (elementCount);
    }
}
