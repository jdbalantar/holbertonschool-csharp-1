using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> C_node = myLList.First;
        int _count = 0;
        while(C_node != null)
        {
            if(_count == index)
                myLList.Remove(C_node);
            _count += 1;
            C_node = C_node.Next;
        }
    }
}