using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7};
            Console.WriteLine("Input not sorted array:");
            PrettyPrint(inputArray);

            var heap = new Heap(inputArray);
            var resultArray = heap.Sort();

            Console.WriteLine("Output sorted array:");
            PrettyPrint(resultArray);  
        }

        /// <summary>
        /// Print array to console in a convinient form.
        /// </summary>
        /// <param name="array">An array for output.</param>
        static void PrettyPrint(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(String.Format("{0} ", array[i]));
            Console.WriteLine();
        }
    }
}
