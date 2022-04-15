using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> C_node = myLList.First;
        while(C_node != null)
        {
            if(C_node.Value < n)
            {
                C_node = C_node.Next;
            }
            else
            {
                myLList.AddBefore(C_node, n);
                return myLList.First;
            }   
        }
        myLList.AddLast(n);
        return myLList.First;  
    }
}