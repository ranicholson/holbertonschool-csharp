using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int dataSum = 0;
        foreach (int storedValue in myLList)
        {
            dataSum += storedValue;
        }
        return (dataSum);
    }
}
