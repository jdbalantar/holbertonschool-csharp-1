using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        int i;

        if (index < 0 || index > array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] == index)
            {
                array[i] = n;
            }
        }
        return array;
    }
}

