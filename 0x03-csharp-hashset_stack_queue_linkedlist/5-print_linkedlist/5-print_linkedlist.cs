using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {   
        if (size < 0)
        {
            LinkedList<int> newnode = new LinkedList<int>();
            return newnode;
        }
        List<int> new_list = new List<int>();
        for (var i = 0; i < size; i++)
        {
            new_list.Add(i);
            Console.WriteLine(i);
        }
        LinkedList<int> llist = new LinkedList<int>(new_list);
        return llist;
        
    }
}