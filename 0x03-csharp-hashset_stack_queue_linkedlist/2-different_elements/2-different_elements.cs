using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> nl1 = new List<int>();
        List<int> nl2 = new List<int>();

        foreach (int elemlis1 in list1)
        {
            foreach (int elemlis2 in list2)
            {
                if (elemlis1 == elemlis2)
                    nl1.Add(elemlis2);
            }
        }
        list1.AddRange(list2);
        list1.Sort();

        foreach (int x in list1)
        {
            if (nl1.Contains(x) == false)
            {
                nl2.Add(x);
            }
        }
        return (nl2);
    }
}