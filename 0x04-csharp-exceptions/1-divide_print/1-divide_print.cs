﻿using System;
using System.Collections.Generic;
class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = (a / b);
            
            
        }
        catch (System.Exception)
        {
             System.Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}

