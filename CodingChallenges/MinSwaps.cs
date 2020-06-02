using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class MinSwaps
    {
        //return minimum number of swaps to sort an array
        static int minimumSwaps(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                int index = i + 1;
                //is current number in wrong position?
                if(arr[i] != index)
                {
                    //value of current number
                    int x = arr[i];
                    //value of number at current numbers correct index
                    int y = arr[x-1];
                    //swap number at current numbers with current number 
                    arr[i] = arr[x-1];
                    arr[x-1] = x;
                    //reduce loop counter too keep loop running 
                    i--;
                    //count swaps
                    count++;
                }
               
            }
            return count;
        }

      

    //    static void Main(string[] args)
    //    {
    //        int[] q = {4,3,1,2};
    //        Console.WriteLine(minimumSwaps(q));

    //    }
    }
}
