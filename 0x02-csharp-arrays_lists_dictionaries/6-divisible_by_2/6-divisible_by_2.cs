using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> NewList = new List<bool>();
        foreach(int elem in myList)
        {
            if (elem % 2 == 0)
            {
                NewList.Add(true);
            }
            else
                NewList.Add(false);
        }
        return NewList;
    }
}