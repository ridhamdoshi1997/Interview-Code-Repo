using System;
using System.Collections.Generic;

namespace Move_Zeroes
{
    internal class Program
    {
        public static int[] MoveZeroes(int[] nums)
        {
            List<int> Zerolst = new List<int>();
            List<int> commonlst = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        Zerolst.Add(nums[i]);
                    }
                    else
                    {
                        commonlst.Add(nums[i]);
                    }
                }
                commonlst.AddRange(Zerolst);
            return commonlst.ToArray();
        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] result = MoveZeroes(nums);
                foreach(int i in result)
                {
                    Console.WriteLine(result[i]);
                }
            
        }
    }
}
