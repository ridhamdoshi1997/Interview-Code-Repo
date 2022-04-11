using System;
using System.Collections.Generic;
using System.Linq;

namespace insertionSort
{
    internal class Program
    {
        public static List<int> SortList(List<int> unsortedList)
        {
           
            for(int i=0; i<unsortedList.Count; i++)
            {
                int current = i;
                while(current>0 && unsortedList[current]<unsortedList[current-1])
                {
                    int temp = unsortedList[current];
                    unsortedList[current] = unsortedList[current-1];
                    unsortedList[current-1] = temp;
                    current--;
                }
            }
            return unsortedList;
        }
        public static List<string> SplitWords(string s)
        {
            return string.IsNullOrEmpty(s) ? new List<string>() : s.Trim().Split(' ').ToList();
        }
        static void Main(string[] args)
        {
            List<int> unsortedList = SplitWords(Console.ReadLine()).Select(int.Parse).ToList();
            List<int> res = SortList(unsortedList);
            Console.WriteLine(String.Join(' ', res));
        }
    }
}
