using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            int len = nums.Length;
            Dictionary<int, int> visited = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                var lookingFor = target - nums[i];
                if (visited.ContainsKey(lookingFor))
                    return new int[] { visited[lookingFor], i };
                else
                    if (!visited.ContainsKey(nums[i]))
                    visited.Add(nums[i], i);
            }
            return new int[0];
        }
        static void Main(string[] args)
        {
            int[] vs = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            foreach (int i in vs)
                Console.WriteLine(vs[i]);
        }
    }
}
