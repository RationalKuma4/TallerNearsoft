using System;

namespace Heaps
{
    public class Heap : IHeap
    {
        private int[] _heap;

        public Heap(int[] array)
        {
            if (array.Length <= 0 || array == null)
                throw new Exception("Array nulo");
            _heap = BulidMaxHeap(array);
        }

        private int[] BulidMaxHeap(int[] array)
        {
            //checar esto
            var heap = array;
            var half = CalculateHalf(array);
            //Decrementa por que va a la izquierda
            for (int i = half; i >= 0; i--)
            {
                Heapify(heap, i);
            }
            return heap;
        }

        private void Heapify(int[] heap, int i)
        {
            int leftChild = GetLeftChildIndex(i);
            int rightChild = GetRightChildIndex(i);
            int heapLenght = heap.Length;
            //Valor actual del nodo
            int currentValue = heap[i];

            bool hasLeftChild = leftChild < heapLenght;
            bool hasRightChild = rightChild < heapLenght;
            int maxIndex;

            //Si no hay hijos regresamos
            if (!hasLeftChild && !hasRightChild) return;

            //Buscamoen los dos hijos
            if (hasLeftChild && hasRightChild)
            {
                int leftChildValue = heap[leftChild];
                int rightChildValue = heap[rightChild];
                maxIndex = leftChildValue > rightChildValue ? leftChild : rightChild;
            }
            else if (hasLeftChild)
            {
                maxIndex = leftChild;
            }
            else
            {
                maxIndex = rightChild;
            }

            //Solo tiene un hijo
            //maxIndex = hasLeftChild ? leftChild : rightChild;

            //Switch de valores
            if (currentValue < heap[maxIndex])
            {
                heap[i] = heap[maxIndex];
                heap[maxIndex] = currentValue;
                Heapify(heap, maxIndex);
            }
        }

        private int GetLeftChildIndex(int i)
        {
            return i == 0 ? 1 : i * 2 + 1;
        }

        private int GetRightChildIndex(int i)
        {
            return i == 0 ? 2 : i * 2 + 2;
        }

        private int CalculateHalf(int[] array)
        {
            var half = array.Length / 2;
            return half % 2 == 0 ? half : ++half;
        }

        public int GetMax()
        {
            return _heap[0];
        }

        public int GetMin()
        {
            throw new NotImplementedException();
        }

        public int[] HeapSort()
        {
            //checar esto
            var pheap = _heap;
            int[] sortedHeap = new int[_heap.Length];
            int root = pheap[0];
            var lenght = sortedHeap.Length;

            /*
             * i = 0 n- (0+1)
             * i = 1 n-(1+1) = n-2
             * i = 2 m - (2+1)
             * y asi
             * */
            for (int i = 0; i < lenght; i++)
            {
                sortedHeap[i] = pheap[0];
                int lastIndex = lenght - (i + 1);
                pheap[0] = pheap[lastIndex];
                //ver igualdad
                pheap = Array.Copy(pheap, lastIndex);
                if (lastIndex != 0)
                {
                    Heapify(pheap, 0);
                }
            }
            return sortedHeap;
        }
    }
}
