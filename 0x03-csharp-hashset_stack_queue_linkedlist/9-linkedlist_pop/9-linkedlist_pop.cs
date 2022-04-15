using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int result;
        result = 0;
        if (myLList.Count <= 0)
        {
            return 0;
        }
        result = myLList.First.Value;
        myLList.RemoveFirst();
        return result;
    }
}