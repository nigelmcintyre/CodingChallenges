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

class RotateLeft
{

    // rotate int array d times
    static int[] rotLeft1(int[] a, int d)
    {
        int size = a.Length;
        // create a new array lenght of original
        int[] rotated_arr = new int[size];
        int i = 0;
        int rotate_index = d;

        // items after position a[d] in the array are put at the start
        while(rotate_index < size)
        {
            rotated_arr[i] = a[rotate_index];
            rotate_index++;
            i++;

        }
        // fill rest of the array with remaining ints
        rotate_index = 0;
        while (rotate_index < d)
        {
            rotated_arr[i] = a[rotate_index];
            rotate_index++;
            i++;
            
        }

        return rotated_arr;

        
    }

    static int[] rotLeft2(int[] a, int d)
    {
        int[] result;

        List<int> numbers = a.ToList();


        // put first element at the end of the list, repeat d times
        for (int i = 0; i < d; i++)
        {
            int first = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(first);

        }

        result = numbers.ToArray();

        return result;
    }

    //static void Main(string[] args)
    //{
        
    //    int[] a = { 1, 2, 3, 4, 5 };
    //    int d = 4;
    //    int[] result1 = rotLeft1(a, d);
    //    int[] result2 = rotLeft2(a, d);
    //    foreach ( int i in result1){
    //        Console.WriteLine(i);
    //    }
    //    foreach (int i in result2)
    //    {
    //        Console.WriteLine(i);
    //    }

    //}
}

