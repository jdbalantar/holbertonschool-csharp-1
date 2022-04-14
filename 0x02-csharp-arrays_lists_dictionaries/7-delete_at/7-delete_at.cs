﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count)
        {
            Console.Write("Index is out of range\n");
            return myList;
        }
        for (int i = 0; i < myList.Count; i++)
        {
            if (i == index)
            {
                myList.Remove(myList[i]);
                break;
            }
        }

        return myList;
    }
}