using System;
using System.Collections.Generic;
using System.Linq;

namespace Mark_and_Toys
{
    internal class Program
    {
        public static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int len = prices.Count;
            int counter = 0;
            var lookingFor = k;
            Dictionary<int, int> visited = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                
                lookingFor =lookingFor - prices[i];
                if (lookingFor>=0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                /*if (visited.ContainsKey(lookingFor))
                    return visited.Count;
                else
                    if (!visited.ContainsKey(prices[i]))
                    visited.Add(prices[i], i);*/
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

            int result = maximumToys(prices, k);
            Console.WriteLine("Output:");
            Console.WriteLine(result);
        }
    }
}
