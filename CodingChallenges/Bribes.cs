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
  

    class Bribes
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int swapCount = 0;
            int temp = 0;
            for(int i = q.Length -1; i >= 0; i--)
            {
                if(q[i] != i + 1)
                {
                    if(((i-1) >= 0) && q[i-1] == (i + 1))
                    {
                        swapCount++;
                        swap(q, i, i - 1);

                    } else if(((i-2) >= 0) && q[i-2] == (i + 1))
                    {
                        swapCount += 2;
                        swap(q, i - 2, i - 1);
                        swap(q, i - 1, i);
                    
                    } else
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                    
                }
            }
            Console.WriteLine(swapCount);


        }

        static void swap(int[] q, int x, int y)
        {
            int temp = q[x];
            q[x] = q[y];
            q[y] = temp;
        }

        //static void Main(string[] args)
        //{
        //    int[] q = { 1, 2,5, 3, 7, 8, 6, 4 };
        //    minimumBribes(q);
            
        //}
    }
}
