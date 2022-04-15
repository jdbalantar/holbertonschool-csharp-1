using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int mcount = 0;
        if (myLList.Count < n )
            return 0;
        foreach(int i in myLList)
            {
                if (mcount == n)
                    return i;
                mcount += 1;
            }
        return 0;
    }
}