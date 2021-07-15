using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> integerLinkList = new LinkedList<int>();
        if (size < 0)
        {
            return (integerLinkList);
        }
        for (int x = 0; x < size; x++)
        {
            integerLinkList.AddLast(x);
            Console.WriteLine(x);
        }
        return (integerLinkList);
    }
}