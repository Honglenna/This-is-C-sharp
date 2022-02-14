﻿using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;       // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b;             // b에 담긴 값을 언박싱해서 스택에 저장

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);

            double x = 3.1414213;
            object y = x;               // x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y;       // y에 담긴 값을 언박싱해서 스택에 저장

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
        }
    }
}

