using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0)
        {
            Console.Write("Index is out of range");
            return myList;
        }
        else
        {
            for (int i = 0; index < myList.Count; index++)
            {
                if (i == index)
                {
                    myList.Remove(myList[i]);
                    break;
                }
            }
        }
        return myList;
    }
}