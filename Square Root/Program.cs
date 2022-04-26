using System;

namespace Square_Root
{
    internal class Program
    {
        public static int SquareRoot(int n)
        {
            if (n == 0) return 0;
            int left = 1;
            int right = n;
            int res = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= n / mid)
                {
                    res = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return res;
           
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = SquareRoot(n);
            Console.WriteLine(res);
        }
    }
}
