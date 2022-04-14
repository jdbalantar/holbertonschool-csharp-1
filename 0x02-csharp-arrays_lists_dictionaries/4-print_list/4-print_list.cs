using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;

        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }
        List<int> MyList = new List<int>();
        for(i = 0; i < size; i++)
        {
            MyList.Add(i);
            Console.Write(MyList[i]);
            if (i < size - 1)
                Console.Write(" "); 
        }
        Console.Write("\n");
        return MyList;
    }
}