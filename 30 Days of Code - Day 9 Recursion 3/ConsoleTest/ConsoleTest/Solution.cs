﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the factorial function below.
    static int factorial(int n)
    {
        if (n<2)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
        


    }

    static void Main(string[] args)
    {
     
        int n = Convert.ToInt32(Console.ReadLine());

        int result = factorial(n);
        Console.WriteLine(result);
        Console.ReadKey();
   
    }
}
