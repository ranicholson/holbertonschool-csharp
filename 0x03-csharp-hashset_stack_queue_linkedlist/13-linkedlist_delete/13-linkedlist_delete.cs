using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> killNode = myLList.First;
        int indexTracker = 0;
        while (killNode != null)
        {
            if (indexTracker == index)
            {
                myLList.Remove(killNode);
                break;
            }
            killNode = killNode.Next;
            indexTracker++;
        }
    }
}
