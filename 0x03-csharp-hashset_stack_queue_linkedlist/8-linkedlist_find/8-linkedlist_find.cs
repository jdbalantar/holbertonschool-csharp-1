using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var index = 0;
        if(myLList.Contains(value))
        {
            foreach(int i in myLList)
            {
                if (i == value)
                    return(index);
                index += 1;
            }
        } 
        else
        // Return -1 if value not is in the list
            return(-1);
        return -1;
    }
}