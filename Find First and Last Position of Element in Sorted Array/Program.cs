using System;

namespace Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    internal class Program
    {
        public static  int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
               
                return new int[] { -1,-1};
            }

            int firstpos = binarySearch(nums, 0, nums.Length - 1, target);
            if (firstpos == -1)
            {
                return new int[] { -1, -1 };
            }
            int startpos = firstpos;
            int endpos = firstpos;
            int temp1=0, temp2=0;
            while (startpos != -1)
            {
                temp1 = startpos;
                startpos = binarySearch(nums, 0, startpos - 1, target);
            }
            startpos = temp1;
            while (endpos != -1)
            {
                temp2 = endpos;
                endpos = binarySearch(nums, endpos + 1, nums.Length - 1, target);
            }
            endpos = temp2;
            return new int[] {startpos, endpos };

        }
        public static int binarySearch(int[] nums, int left, int right, int target)
        {
            //int left = 0;
            //int right = nus.Length - 1;
            //int boundaryIndex = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target) return mid;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int[] result = SearchRange(nums, 8);
            foreach(int n in result)
            Console.WriteLine(n);
        }
    }
}
