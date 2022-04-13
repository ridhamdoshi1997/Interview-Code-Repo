using System;

namespace quickSort
{
    internal class Program
    {
		public static int partition(int[] arr, int low, int high)
		{
			int pivot = arr[high];
			int i = (low - 1); // index of smaller element 
			int temp;
			for (int j = low; j < high; j++)
			{
				// If current element is smaller than or 
				// equal to pivot 
				if (arr[j] <= pivot)
				{
					i++;

					// swap arr[i] and arr[j] 
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}

			// swap arr[i+1] and arr[high] (or pivot) 
			temp = arr[i + 1];
			arr[i + 1] = arr[high];
			arr[high] = temp;

			return i + 1;
		}
		public static void sort(int[] arr, int low, int high)
		{
			if (low < high)
			{
				/* pi is partitioning index, arr[pi] is 
				now at right place */
				int pi = partition(arr, low, high);

				// Recursively sort elements before 
				// partition and after partition 
				sort(arr, low, pi - 1);
				sort(arr, pi + 1, high);
			}
		}

		public static void printArray(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n; ++i)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine();
		}
		static void Main(string[] args)
        {
			Console.WriteLine("Enter the Number of Elements:");
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			sort(array,0,n-1);
			Console.WriteLine("Sorted Array:");
			printArray(array);
		}
    }
}
