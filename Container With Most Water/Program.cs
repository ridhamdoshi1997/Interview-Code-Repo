using System;

namespace Container_With_Most_Water
{
    internal class Program
    {
        public static int MaxArea(int[] height)
        {
            if(height.Length<=1)
            {
                return 0;
            }
            int Max_Area = 0;

            /* Brute Force 
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int New_Max_Area = Math.Min(height[i], height[j]) * (j - i);
                    if (New_Max_Area > Max_Area)
                    {
                        Max_Area = New_Max_Area;
                    }
                }
            }

            */
            int a = 0;
            int b = height.Length-1;
            while(a<b)
            {
                int New_Max_Area = Math.Min(height[a], height[b]) * (b - a);

                if(New_Max_Area > Max_Area)
                {
                   Max_Area = New_Max_Area;
                }
                if(height[a]<height[b])
                {
                    a++;
                }
                else
                {
                    b--;
                }
            }
            return Max_Area;    
        }
        static void Main(string[] args)
        {
            int vs = MaxArea(new int[] { 2, 7, 11, 15 });
            
           Console.WriteLine(vs); ;
        }
    }
}
