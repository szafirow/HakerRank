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
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        var d = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine().Split(' ');
            d.Add(s[0], s[1]);
        }
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine();
            if (d.ContainsKey(s))
            {
                Console.WriteLine(s + "=" + d[s]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
