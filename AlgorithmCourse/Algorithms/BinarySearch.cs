using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCourse.Algorithms
{
    public class BinarySearch
    {
        public int SearchIndexOfValue(int[] array, int searchValue, int start, int end)
        {
            int middle = (start + end) / 2;
            if(array[middle] == searchValue)
            {
                return middle;
            }
            else if(array[middle] > searchValue)
            {
                return SearchIndexOfValue(array, searchValue, start, middle);
            }
            else
            {
                return SearchIndexOfValue(array, searchValue, middle + 1, end);
            }
        }
    }
}
