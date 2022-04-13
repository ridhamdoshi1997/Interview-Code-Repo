using System;
using System.Collections.Generic;
using System.Linq;

namespace selectionSorts
{
    internal class Program
    {
        public static List<int> sortList(List<int> unsortedList)
        {
            for(int i=0;i<unsortedList.Count;i++)
            {
                int MinIndex = i;
                for(int j=i;j<unsortedList.Count;j++)
                {
                    if(unsortedList[j]<unsortedList[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                int temp = unsortedList[i];
                unsortedList[i] = unsortedList[MinIndex];
                unsortedList[MinIndex] = temp;
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
            List<int> res = sortList(unsortedList);
            Console.WriteLine(String.Join(' ', res));

        }
    }
}
