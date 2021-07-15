using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            LinkedListNode<int> newNode = new LinkedListNode<int>(n);
            LinkedListNode<int> currentNode = myLList.First;
            while (currentNode != null)
            {
                if (currentNode.Value > newNode.Value)
                {
                    myLList.AddBefore(currentNode, newNode);
                    break;
                }
                currentNode = currentNode.Next;
            }
            return(newNode);
            
        }
    }
