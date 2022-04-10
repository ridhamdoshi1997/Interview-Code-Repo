using System;

namespace Sparse_Array
{
    class Program
    {
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] temp = new int[queries.Length];
            int counter = 0;
            for(int i=0;i<queries.Length;i++)
            {
                for(int j=0;j<strings.Length;j++)
                {
                    if(queries[i]==strings[j])
                    {
                        counter++;
                    }
                }
                temp[i] = counter;
                counter = 0;
            }
            return temp;

        }
        static void Main(string[] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);
            Console.WriteLine(String.Join("\n", res));
        }
 
    }
}
