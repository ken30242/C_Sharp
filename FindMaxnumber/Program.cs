using System;

public class FindMaxnumber
{
    public static void Main(string[] args)
    {
        int num1 = 20;
        int num2 = 15;
        int num3 = 19;
        int num4 = 50;
        int num5 = 10;
        int  max_number = 0;

        if (num1 > max_number)
        {
            max_number = num1;
        }
        if (num2 > max_number)
        {
            max_number = num2;
        }
        if (num3 > max_number)
        {
            max_number = num3;
        }
        if (num4 > max_number)
        {
            max_number = num4;
        }
        if (num5 > max_number)
        {
            max_number = num5;
        }

        Console.WriteLine("Max num: " + max_number);
    }
}