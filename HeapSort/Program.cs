using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7};

            var heap = new Heap(inputArray);
            Console.WriteLine("Input not sorted array:");
            Console.WriteLine(heap.ToString());

            var resultArray = heap.Sort();

            Console.WriteLine("Output sorted array:");
            Console.WriteLine(heap.ToString()); 
        }
    }
}
