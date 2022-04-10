using System;

namespace InsertsionSort
{
    class Program
    {
        static void insertionSort1(int n, int[] arr)
        {
            var i = arr.Length - 1;
            var currElement = arr[i];
            var j = i - 1;
            for (; j >= 0; j--)
            {
                if (currElement < arr[j])
                {
                    arr[j + 1] = arr[j];
                    Console.WriteLine(String.Join(" ", arr));
                }
                else
                    break;
            }

            arr[j + 1] = currElement;
            Console.WriteLine(String.Join(" ", arr));

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            insertionSort1(n, arr);
        }
    }
}
