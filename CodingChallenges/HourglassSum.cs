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


namespace CodingChallenges
{
    class HourglassSum
    {
        // Gets the sum of all the hour glass in a 6x6 2D array
        static int hourglassSum(int[][] arr)
        {

            List<int> resultList = new List<int>();
            int x = 0;
            int y = 0;

            int columns =  arr[0].Length - 2;
            int rows = arr.Length-2;
            // For every row
            while (x < rows)
            {   
                // For every column
                while (y < columns)
                {
                    int top = 0;
                    int middle = arr[x + 1][y + 1];
                    int bottom = 0;
                    // Iterates over top and bottom rows
                    for (int i = y; i < y + 3; i++)
                    {
                        // Adding up top and bottom rows
                        top += arr[x][i];
                        bottom += arr[x + 2][i];
                    }
                    // Sum the hourglass
                    int sum = top + bottom + middle;
                    // Add it to the list of sums
                    resultList.Add(sum);
                    y++;
                }
                y = 0;
               x++;
            }
           
            return resultList.Max();

        }
        //static void Main(string[] args) 
        //{
        //    int[][] arr = new int[6][];

        //    String[] numbers = { "1 1 1 0 0 0", "0 1 0 0 0 0", "1 1 1 0 0 0", "0 0 2 4 4 0", "0 0 0 2 0 0", "0 0 1 2 4 0" };

        //    for(int i = 0; i < 6; i++) {
        //        arr[i] = Array.ConvertAll(numbers[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    }

        //    int result = hourglassSum(arr);
        //    Console.WriteLine(result);

        //}
    }
    
}
