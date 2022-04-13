using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace mergeSort
{
    internal class Program
    {
        public static int[] MergeSort(int[] arr)
        {
            if(arr.Length<=1)
            {
                return arr;
            }
            int Mid = arr.Length/2; // To find the Mid point of the Array
            int[] left = new int[Mid];
            int[] right;
            int[] result = new int[arr.Length];

            if (arr.Length % 2 == 0) 
                right = new int[Mid];  // If Even then size of the right Array will be the same as Mid point
            else
                right = new int[Mid + 1]; // Else +1 then Mid point

            for (int i = 0; i < Mid; i++)
            {
                left[i] = arr[i];   // Populating the left Array
            }

            int x = 0;
            for (int i = Mid; i < arr.Length; i++)
            {
                right[x] = arr[i];  // Populating the Right Array
                x++;
            }

            left = MergeSort(left); // Sorting the Left array with the Recursion
            right = MergeSort(right); // Soring the Right array with the Recursion
            result = Merge(left,right); // Sorting the whole array
            return result;


        }
        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while(indexLeft<left.Length || indexRight <right.Length)
            {
                if(indexLeft<right.Length && indexRight<right.Length) // if both the array has the elements 
                {
                    if(left[indexLeft] <= right[indexRight]) // if left side is smaller then the right side
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if(indexLeft<left.Length) // if only left array has the elements
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if(indexRight<right.Length) // if only right array has the elements
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] result = MergeSort(array);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
