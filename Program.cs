namespace SortingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 1, 6 };
            BubbleSort.Bubblesort(arr);

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.sort(arr);
         }
    }
}