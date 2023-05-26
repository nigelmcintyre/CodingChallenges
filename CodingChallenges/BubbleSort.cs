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

namespace CodingChallenges
{
    class Result
    {

        /*
         * Complete the 'countSwaps' function below.
         *
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static void countSwaps(List<int> a,int n)
        {
            int numSwaps = 0;
            int firstElement;
            int lastElement;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        int temp = 0;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numSwaps++;
                    }
                }

            }
            firstElement = a[0];
            lastElement = a[n - 1];
            Console.WriteLine("Array is sorted in " + numSwaps + " swaps.");
            Console.WriteLine("First Element: " + firstElement);
            Console.WriteLine("Last Element: " + lastElement);
        }
    }

    class Solution
    {
        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        //    Result.countSwaps(a,n);
        //}
    }
}
