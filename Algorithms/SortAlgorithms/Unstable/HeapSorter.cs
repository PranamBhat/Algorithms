﻿using System;
using Algorithms.Helpers;

namespace Algorithms.SortAlgorithms
{
    /// <summary>
    /// Using binary search tree
    /// Best:               O(n log(n))
    /// Average:            O(n log(n))
    /// Worst:              O(n log(n))
    /// Additional memory:  1
    /// </summary>
    /// <remarks>
    /// + In-place
    /// + In worst case: n log(n)
    /// - Not simple in implementation
    /// - In each step - chaotic read in array -> bad works with caching
    /// - Doesn't work with linked lists
    /// - Worst = Best
    /// - Not stable
    /// <see cref="MergeSorter{T}"/> uses more memory but faster (O(n log(n)) with less const) and doesn't degradate.
    /// </remarks>
    /// <typeparam name="T">Type of array's elements</typeparam>
    public class HeapSorter<T> : ISorter<T> where T : IComparable
    {
        public void sort(T[] array)
        {
            int heapLength = array.Length;

            for (var i = (heapLength - 1) / 2; i >= 0; i--)
            {
                this.heapify(array, heapLength, i);
            }

            for (var i = array.Length - 1; i > 0; i--)
            {
                SortHelper.swap(array, 0, i);                       // put largest element from heap head to the end of array

                heapLength--;
                this.heapify(array, heapLength, 0);
            }
        }

        private void heapify(T[] array, int length, int begin)
        {
            int left = begin * 2 + 1;
            int right = begin * 2 + 2;
            int indexOfLargestElement = 0;

            if (left < length && array[left].CompareTo(array[begin]) > 0)            // find largest element of i, 2i + 1 and 2i + 2
            {
                indexOfLargestElement = left;
            }
            else
            {
                indexOfLargestElement = begin;
            }

            if (right < length && array[right].CompareTo(array[indexOfLargestElement]) > 0)
            {
                indexOfLargestElement = right;
            }

            if (indexOfLargestElement != begin)
            {
                SortHelper.swap(array, indexOfLargestElement, begin);    // put largest element to i-place and run heapify for replaced element

                this.heapify(array, length, indexOfLargestElement);
            }
        }
    }
}
