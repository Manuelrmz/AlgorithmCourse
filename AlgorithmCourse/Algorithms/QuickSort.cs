using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCourse.Algorithms
{
    public class QuickSort
    {
        public int[] Sort(int[] inputArray)
        {
            int n = inputArray.Length - 1;
            // Pick a pivot
            // Search for a place where you can switch it and that is your middle
            // Then apply the same process with both half.
            Sort(ref inputArray, 0, n);
            return inputArray;
        }
        private void Sort(ref int[] a, int start, int end)
        {
            int pivotPosition = Pivot(ref a, start, end);
            if (start < pivotPosition -1)
                Sort(ref a, start, pivotPosition-1);
            if (pivotPosition < end)
                Sort(ref a, pivotPosition, end);
        }
        private int Pivot(ref int[] a, int start, int end)
        {
            int middle = (end + start) / 2;
            int left = start;
            int right = end;
            while (start <= end)
            {
                while (left >= 0 && a[left] < a[middle])
                    left++;
                while (right >= 0 && a[right] > a[middle])
                    right--;
                if(start <= end)
                {
                    int temp = a[start];
                    a[start] = a[end];
                    a[end] = temp;
                    end--;
                    start++;
                }
            }
            return start;
        }
    }
}
