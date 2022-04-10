using System;
using System.Collections.Generic;
using System.Linq;

namespace Left_Rotation_Of_Array
{
    class Program
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int[] a = arr.ToArray();
            int[] array1 = a.Take(d).Reverse().ToArray();
            int[] array2 = a.Skip(d).Take(a.Length - d + 1).Reverse().ToArray();
            
            int[] array3 = array1.Concat(array2).Reverse().ToArray();
            List<int> list = array3.ToList();
            return list;
        }
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = rotateLeft(d, arr);
            Console.WriteLine(String.Join(" ", result));

        }
    }
}
