using System;

namespace Gemstones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "abcd", "ab", "ab" };
            string s = arr[0];
            int gems = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 1;
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j].Contains(s[i]))
                    {
                        count++;
                        int index = arr[j].IndexOf(s[i]);
                        arr[j] = arr[j].Substring(0, index) + arr[j].Substring(index + 1);
                    }
                }
                if (count >= arr.Length)
                    gems++;
            }
            Console.WriteLine(gems);
            Console.ReadLine();
        }
    }
}
