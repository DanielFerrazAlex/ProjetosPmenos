﻿using System;
namespace Program;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                Console.Write("*");
                if (i <= j)
                    break;
            }
            Console.WriteLine();
        }
    }
}
