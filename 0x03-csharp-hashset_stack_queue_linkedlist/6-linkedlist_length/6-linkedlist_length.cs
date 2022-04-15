using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        var amount = 0;
        foreach(int i in myLList)
        {
            amount = amount + 1;
        }
        return(amount);
        
    }
}