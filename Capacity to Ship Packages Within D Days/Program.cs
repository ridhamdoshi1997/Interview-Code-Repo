using System;
using System.Collections.Generic;
using System.Linq;

namespace Capacity_to_Ship_Packages_Within_D_Days
{
    internal class Program
    {
        public static bool feasible(List<int> weights, int maxWeight, int d)
        {
            int reqDays = 1;
            int capacity = maxWeight;
            int i = 0, n = weights.Count;
            while (i < n)
            {
                if (weights[i] <= capacity)
                {
                    capacity -= weights[i];
                    i++;
                }
                else
                {
                    reqDays++;
                    capacity = maxWeight;
                }
            }
            return reqDays <= d;
        }

        public static int MinMaxWeight(List<int> weights, int d)
        {
            int minPtr = weights.Max();
            //int maxAge = myTypes.Max(t => t.Age)
            int maxPtr = 0;
            foreach(int weight in weights)
            { 
                maxPtr += weight;
            }
            int boundaryIndex = maxPtr;
            while (minPtr <= maxPtr)
            {
                int midpoint = (minPtr + maxPtr) / 2;
                if (feasible(weights, midpoint, d))
                {
                    boundaryIndex = midpoint;
                    maxPtr = midpoint - 1;
                }
                else
                {
                    minPtr = midpoint + 1;
                }
            }
            return boundaryIndex;
        }

        public static List<string> SplitWords(string s)
        {
            return string.IsNullOrEmpty(s) ? new List<string>() : s.Trim().Split(' ').ToList();
        }

        static void Main(string[] args)
        {
            List<int> weights = SplitWords(Console.ReadLine()).Select(int.Parse).ToList();
            int d = int.Parse(Console.ReadLine());
            int res = MinMaxWeight(weights, d);
            Console.WriteLine(res);
        }
    }
}
