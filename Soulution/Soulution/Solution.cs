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

        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            arr[i] = s;
        }

        for (int i = 0; i < n; i++)
        {
            char[] arr2 = arr[i].ToCharArray();
            string even = "";
            string odd = "";
            for (int j = 0; j < arr2.Length; j++)
            {
                if (j % 2 == 0) even += arr2[j];
                if (j % 2 != 0) odd += arr2[j];
            }
            Console.WriteLine(even + " " + odd);
        }

        Console.ReadKey();


    }
}
