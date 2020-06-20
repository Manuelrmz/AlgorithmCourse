using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCourse.Algorithms
{
    public class MergeSort
    {
        public int[] Sort(int[] inputArray)
        {
            return Sort(inputArray, 0, inputArray.Length - 1);
        }
        public int[] Sort(int[] inputArray, int start, int end)
        {
            if(end - start == 0)
            {
                return new int[] { inputArray[start] };
            }
            else if(end - start == 1)
            {
                if (inputArray[start] > inputArray[end])
                    return new int[] { inputArray[end], inputArray[start] };
                else if (inputArray[start] < inputArray[end])
                    return new int[] { inputArray[start], inputArray[end] };
                else return inputArray;
            }
            int middle = (end + start) / 2;
            return Merge(Sort(inputArray, start, middle) , Sort(inputArray, middle + 1, end));
        }
        private int[] Merge(int [] a1, int[] a2)
        {
            int resultCont = 0;
            int totalRecords = a1.Length + a2.Length;
            int[] result = new int[totalRecords];
            int cont1 = 0;
            int cont2 = 0;
            while ((cont1 < a1.Length || cont2 < a2.Length) && resultCont < totalRecords)
            {
                if (cont1 < a1.Length && cont2 < a2.Length)
                {
                    if(a1[cont1] > a2[cont2])
                    {
                        result[resultCont] = a2[cont2];
                        cont2++;
                        resultCont++;
                    }
                    else if(a1[cont1] < a2[cont2])
                    {
                        result[resultCont] = a1[cont1];
                        cont1++;
                        resultCont++;
                    }
                    else
                    {
                        result[resultCont] = a1[cont1];
                        resultCont++;
                        result[resultCont] = a2[cont2];
                        cont1++;
                        cont2++;
                        resultCont++;
                    }
                }
                else if(cont1 == a1.Length && cont2 < a2.Length)
                {
                    result[resultCont] = a2[cont2];
                    cont2++;
                    resultCont++;
                }
                else
                {
                    result[resultCont] = a1[cont1];
                    cont1++;
                    resultCont++;
                }
            }
            return result;
        }
    }
}
