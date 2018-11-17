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

        int rem = 0, s=0 ,t = 0;
        string result = string.Empty;

        while (n > 0)
        {
            rem = n % 2; 
            n /= 2;
            if (rem == 1)
            {
                s++;
                if (s >= t)
                {
                    t = s;
                }

                   

            }
            else
            {
                s = 0;
            }
            result = rem.ToString() + result;
        }
        Console.WriteLine(t);
       // Console.WriteLine("Binary:  {0}", result);
        Console.ReadKey();
    }
 }
