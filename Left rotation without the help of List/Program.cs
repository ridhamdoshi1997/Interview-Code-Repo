using System;

namespace Left_rotation_without_the_help_of_List
{
    class Program
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int v;

            for (int i = 0; i < d; i++)
            {
                v = a[0];
                for (int j = 0; j < a.Length; j++)
                {
                    if (j + 1 < a.Length)
                        a[j] = a[j + 1];
                }
                a[a.Length - 1] = v;
            }

            return a;
        }
        static void Main(string[] args)
        {
            string[] nd = "5 2".Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll("1 2 3 4 5".Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);
            Console.WriteLine(string.Join(',', a));
            Console.WriteLine(string.Join(',', result));
        }
    }
}
