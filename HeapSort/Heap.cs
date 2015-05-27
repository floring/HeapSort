using System;
using System.Text;

namespace HeapSort
{
    /// <summary>
    /// Heap class implements HeapSort algorithm for an array of integers.
    /// The heap is often placed in an array with the layout of a complete binary tree.
    /// </summary>
    public class Heap
    {
        private int[] _array;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array">An array which is sorted</param>
        public Heap(int[] array)
        {
            _array = array;
        }

        /// <summary>
        /// Build the heap in array so that largest value is at the root.
        /// </summary>
        private void BuildMaxHeap()
        {
            for (int i = _array.Length / 2; i >= 0; i--)
            {
                MaxHeapify(_array.Length, i);
            }
        }

        /// <summary>
        /// Build a heap from the bottom up to establish the heap property. 
        /// </summary>
        /// <param name="length">Array length</param>
        /// <param name="i">Index element in the array</param>
        private void MaxHeapify(int length, int i)
        {
            int l = Left(i);
            int r = Right(i);
            int largest = i;
            if (l < length && _array[i] < _array[l])
            {
                largest = l;
            }
            if (r < length && _array[largest] < _array[r])
            {
                largest = r;
            }
            if (i != largest)
            {
                Swap(i, largest);
                MaxHeapify(length, largest);
            }
        }

        /// <summary>
        /// Exchange two variables in the array. 
        /// </summary>
        /// <param name="i">1st index</param>
        /// <param name="j">2nd index</param>
        private void Swap(int i, int j)
        {
            int tmp = _array[i];
            _array[i] = _array[j];
            _array[j] = tmp;
        }

        /// <summary>
        /// Get the position of the left node child.
        /// </summary>
        /// <param name="i">Parent position</param>
        /// <returns>Position of the left node child</returns>
        private int Left(int i)
        {
            return 2 * i + 1;
        }

        /// <summary>
        /// Get the position of the right node child.
        /// </summary>
        /// <param name="i">Parent position</param>
        /// <returns>Position of the right node child</returns>
        private int Right(int i)
        {
            return 2 * i + 2;
        }

        /// <summary>
        /// Implement HeapSort algorithm.
        /// </summary>
        /// <returns>Sorted array</returns>
        public int[] Sort()
        {
            BuildMaxHeap();
            for (int i = _array.Length - 1; i > 0; i--)
            {
                Swap(i, 0);
                MaxHeapify(i, 0);
            }
            return _array;
        }

        /// <summary>
        /// Convert the array to its string implementation so that it is suitable for display. 
        /// </summary>
        /// <returns>A string that represents the current array</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < _array.Length; i++)
            {
                sb.AppendFormat(String.Format("{0} ", _array[i]));
            }
            return sb.ToString();
        }

    }
}
