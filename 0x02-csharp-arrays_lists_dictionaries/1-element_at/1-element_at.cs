using System;

class Array
    {
    public static int elementAt(int[] array, int index)
    {
        int i, value = 0;

        if (index < 0)
        {
            Console.WriteLine("Index out of range");
            return (-1);
        }
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] == array[index])
                value = array[index];
        }
        return value;
    }
}

