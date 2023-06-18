using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblem
{
    internal class BubbleSort
    {
        public static void Bubblesort(int[] arr)
        {
            Console.WriteLine("original array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i=0;i<arr.Length; i++)
            {
                for(int j=0;j<arr.Length-1-i;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array");
            for (int i=0;i< arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
