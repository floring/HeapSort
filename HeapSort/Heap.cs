using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class Heap
    {
        private int[] _array;

        public Heap(int[] array)
        {
            _array = array;
        }

        private void BuildMaxHeap()
        {
            for (int i = _array.Length / 2; i >= 0; i--)
            {
                MaxHeapify(_array.Length, i);
            }
        }

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

        private void Swap(int i, int j)
        {
            int tmp = _array[i];
            _array[i] = _array[j];
            _array[j] = tmp;
        }

        private int Left(int i)
        {
            return 2 * i + 1;
        }

        private int Right(int i)
        {
            return 2 * i + 2;
        }

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
    }
}
