using System;
using System.Collections.Generic;
using System.Linq;

namespace Combination_Sum
{
    internal class Program
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            var results = new List<IList<int>>();
            var combination = new Stack<int>();
            FindCombinations(results, candidates, 0, target, combination);

            return results;
        }

        private static void FindCombinations(List<IList<int>> results, int[] candidates, int index, int target, Stack<int> combination)
        {
            if (target == 0)
            {
                results.Add(combination.ToList());
                return;
            }

            for (var i = index; i < candidates.Length && target >= candidates[i]; i++)
            {
                combination.Push(candidates[i]);
                FindCombinations(results, candidates, i, target - candidates[i], combination);
                combination.Pop();
            }
        }
        static void Main(string[] args)
        {
            int[] ar = { 2, 3, 5};
            int total = 8;
            var result = CombinationSum(ar, total);
            foreach(List<int> i in result)
            {
                foreach(int j in i)
                {
                    Console.WriteLine(j);
                }
            }
            
        }
    }
}
