using System;
class Number
{
    public static int PrintLastDigit(int number)
    {
        int value = Math.Abs(number);
        Console.Write("{0}", value % 10);
        return value % 10;
    }
}