﻿using System;

namespace ForFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i ; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
