/* In a 2d array a is the lower index, b is the upper, and k is the query.
 * The goal is to apply the quries to all the elements between the two indexes.
 * This is solved using the prefix sum algorithm.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodingChallenges
{
    class ArrayManipulationSolution
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            // n+2 to prevent and out of bouds exception
            long[] results = new long[n+2];
            long max = 0;
            for(int i = 0; i < queries.Length; i++)
            {

                int lower = queries[i][0];
                // Apply query to lower index
                results[lower] += queries[i][2];
                int upper = queries[i][1];
                // Apply the inverse of the query to the upper+1 index to 0 that index
                results[upper + 1] -= queries[i][2];
            }
            // Call get max and pass in the resulting array from the for loop
            max = getMax(results);
            return max;
        }

        static long getMax(long[] results)
        {
            long max = 0;
            long sum = 0;
            for(int i =0; i < results.Length;i++)
            {
                // Add previous to current index
                sum += results[i];
                // Compare the previous max with current value, update max if larger
                max = Math.Max(max, sum);
            }

            return max;
        }
        


        //static void Main(string[] args)
        //{
        //    int[][] arr = new int[4][];
        //    String[] numbers = { "2 6 8", "3 5 7", "1 8 1","5 9 15" };

        //    for (int i = 0; i < 4; i++)
        //    {
        //        arr[i] = Array.ConvertAll(numbers[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    }
        //    arrayManipulation(10, arr);
        //}
    }

        
}
