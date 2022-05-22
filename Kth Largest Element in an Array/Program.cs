using System;

namespace Kth_Largest_Element_in_an_Array
{
    internal class Program
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            sorting(nums, 0, nums.Length - 1);

            return nums[nums.Length - k];
        }
        public static void sorting(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivot = partition(nums, low, high);
                sorting(nums, low, pivot-1);
                sorting(nums, pivot + 1, high);
            }
        }
        public static int partition(int[] nums, int low, int high)
        {
            int pi = nums[high];
            int i = (low - 1);
            int temp;
            for (int j = low; j < high; j++)
            {
                if (nums[j] <= pi)
                {
                    i++;
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
            temp = nums[i + 1];
            nums[i + 1] = nums[high];
            nums[high] = temp;

            return i + 1;
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 1, 5, 6, 4 };
            int result = FindKthLargest(nums,2);
            Console.WriteLine("Hello World!");
        }
    }
}
