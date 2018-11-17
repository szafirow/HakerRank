using System.CodeDom.Compiler;
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

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());
        String[] arrtemp;

        int[] arr = new int[n];
        arrtemp = Console.ReadLine().Split(' ');
        arr = Array.ConvertAll(arrtemp, Int32.Parse);

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }

        Console.ReadKey();
    }
}
