﻿using System;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a -b;
        }
    }

    class Program
    {
        public static void Main()
        {
            int result = Calculator.Plus(3,4);
            System.Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            System.Console.WriteLine(result);
        }
    }
}