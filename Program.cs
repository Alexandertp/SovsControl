// See https://aka.ms/new-console-template for more information
using System;

public class Program
{

    public static void EatMyCPU(int id)
    {
        for (var i = 0; i < 10000; i++)
        {
            if (i == 69)
            {
                Console.WriteLine("Nice");
            }

        }
    }

    public static void Main()
    {
        int i = 0;
        while (i < 4)
        {
            EatMyCPU(i);
            i++;
        }
        Console.WriteLine("Done for real!");

    }
}