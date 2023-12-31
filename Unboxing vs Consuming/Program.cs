﻿using System;

//ref link:https://www.youtube.com/watch?v=8HnXXOLb-TQ&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=13
// C# --CSC--> MSIL --JIT--> Machine Languange
//  MSIL(MS intermidiate langauge) - boxing/unboxing
//  Machine Languange - Stack/Heap


class MainClass
{
    static void Main()
    {
        object o = 5;
        //((int)o);   // just boxing/unboxing
        //int i = ((int)o);   // consume box
        o.ToString();   //  same as "((int)o).ToString();"
        ((int)o).ToString();    // just boxing/unboxing
    }
}