namespace algoexpert
{
// Min Heap Construction

// Implement a Min Heap class. The class should support insertion, removal (of the minimum / root value), peeking 
// (of the minimum / root value), as well as sifting a value up and down the heap and building the heap from an 
// input array.The heap should be represented in the form of an array.

// Sample input: [48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, 8, 41]
// -> buildHeap(array)
// -> insert(76)
// -> remove()
// -> remove()
// -> insert(87)
// Sample output:
// -> [-5, 2, 6, 7, 8, 8, 24, 391, 24, 56, 12, 24, 48, 41]
// -> [-5, 2, 6, 7, 8, 8, 24, 391, 24, 56, 12, 24, 48, 41, 76]
// -> [2, 7, 6, 24, 8, 8, 24, 391, 76, 56, 12, 24, 48, 41]
// -> [6, 7, 8, 24, 8, 24, 24, 391, 76, 56, 12, 41, 48]
// -> [6, 7, 8, 24, 8, 24, 24, 391, 76, 56, 12, 41, 48, 87]

using System.Collections.Generic;

public partial class Program
    {
        public class MinHeap
        {
            public List<int> heap = new List<int>();

            public MinHeap(List<int> array)
            {
                heap = buildHeap(array);
            }

            // O(n) time | O(1) space
            public List<int> buildHeap(List<int> array)
            {
                int firstParentIdx = (array.Count - 2) / 2;
                for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
                {
                    siftDown(currentIdx, array.Count - 1, array);
                }
                return array;
            }

            // O(log(n)) time | O(1) space
            public void siftDown(int currentIdx, int endIdx, List<int> heap)
            {
                int childOneIdx = currentIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int childTwoIdx = currentIdx * 2 + 2 <=
                      endIdx ? currentIdx * 2 + 2 : -1;
                    int idxToSwap;
                    if (childTwoIdx != -1 && heap[childTwoIdx] < heap[childOneIdx])
                    {
                        idxToSwap = childTwoIdx;
                    }
                    else
                    {
                        idxToSwap = childOneIdx;
                    }
                    if (heap[idxToSwap] < heap[currentIdx])
                    {
                        swap(currentIdx, idxToSwap, heap);
                        currentIdx = idxToSwap;
                        childOneIdx = currentIdx * 2 + 1;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            // O(log(n)) time | O(1) space
            public void siftUp(int currentIdx, List<int> heap)
            {
                int parentIdx = (currentIdx - 1) / 2;
                while (currentIdx > 0 && heap[currentIdx] < heap[parentIdx])
                {
                    swap(currentIdx, parentIdx, heap);
                    currentIdx = parentIdx;
                    parentIdx = (currentIdx - 1) / 2;
                }
            }

            public int Peek()
            {
                return heap[0];
            }

            public int Remove()
            {
                swap(0, heap.Count - 1, heap);
                int valueToRemove = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
                siftDown(0, heap.Count - 1, heap);
                return valueToRemove;
            }

            public void Insert(int value)
            {
                heap.Add(value);
                siftUp(heap.Count - 1, heap);
            }

            public void swap(int i, int j, List<int> heap)
            {
                int temp = heap[j];
                heap[j] = heap[i];
                heap[i] = temp;
            }
        }
    }
}