using SortingAlgorithms.Enums;
using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    class MergeSort : ISortingAlgorithm
    {
        /// <summary>
        /// The methods will return the sorted array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayLength"></param>
        /// <param name="sortTypes"></param>
        /// <returns>Sorted Array</returns>
        public int[] Sort(int[] array, int arrayLength, SortTypes sortType = SortTypes.Asc)
        {
            if (sortType == SortTypes.Asc)
                return SortAsc(array, arrayLength);
            else
                return SortDesc(array, arrayLength);
        }

        public Dictionary<string, string> GetTimeComplexity()
        {
            return new Dictionary<string, string>() {
                { "Best", "O(nlogn)"},
                { "Average", "O(nlogn)" },
                { "Worst", "O(nlogn)" }
            };
        }

        public Dictionary<string, string> GetSpaceComplexity()
        {
            return new Dictionary<string, string>() {
                { "Best", "O(n)"},
                { "Average", "O(n)" },
                { "Worst", "O(n)" }
            };
        }

        private static int[] SortAsc(int[] array, int arrayLength)
        {
            if (arrayLength < 2)
                return array;

            int mid = arrayLength / 2;
            int leftArrayLength = mid;
            int rightArrayLength = arrayLength - mid;

            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            for(int i =0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[i];
            }

            for(int i = 0; i < rightArrayLength; i++)
            {
                rightArray[i] = array[rightArrayLength + i];
            }

            SortAsc(leftArray, leftArrayLength);
            SortAsc(rightArray, rightArrayLength);
            MergeAsc(leftArray, rightArray, array);

            return array;
        }       


        private static void MergeAsc(int[] leftArray, int[] rightArray, int[] array)
        {
            int mergeArrayIndex = 0;
            int leftArrayIndex = 0;
            int rightArrayIndex = 0;
            while(leftArrayIndex < leftArray.Length && rightArrayIndex < rightArray.Length)
            {
                if(leftArray[leftArrayIndex] >= rightArray[rightArrayIndex])
                {
                    array[mergeArrayIndex] = rightArray[rightArrayIndex];
                    rightArrayIndex++;
                }
                else
                {
                    array[mergeArrayIndex] = leftArray[leftArrayIndex];
                    leftArrayIndex++;
                }
                mergeArrayIndex++;
            }

            while(leftArrayIndex < leftArray.Length)
            {
                array[mergeArrayIndex] = leftArray[leftArrayIndex];
                leftArrayIndex++;
                mergeArrayIndex++;
            }


            while (rightArrayIndex < rightArray.Length)
            {
                array[mergeArrayIndex] = leftArray[leftArrayIndex];
                rightArrayIndex++;
                mergeArrayIndex++;
            }
        }

        private static int[] SortDesc(int[] array, int arrayLength)
        {
            if (arrayLength < 2)
                return array;

            int mid = arrayLength / 2;
            int leftArrayLength = mid;
            int rightArrayLength = arrayLength - mid;

            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            for (int i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = 0; i < rightArrayLength; i++)
            {
                rightArray[i] = array[rightArrayLength + i];
            }

            SortDesc(leftArray, leftArrayLength);
            SortDesc(rightArray, rightArrayLength);
            MergeDesc(leftArray, rightArray, array);

            return array;

        }

        private static void MergeDesc(int[] leftArray, int[] rightArray, int[] array)
        {
            int mergeArrayIndex = 0;
            int leftArrayIndex = 0;
            int rightArrayIndex = 0;
            while (leftArrayIndex < leftArray.Length && rightArrayIndex < rightArray.Length)
            {
                if (leftArray[leftArrayIndex] <= rightArray[rightArrayIndex])
                {
                    array[mergeArrayIndex] = rightArray[rightArrayIndex];
                    rightArrayIndex++;
                }
                else
                {
                    array[mergeArrayIndex] = leftArray[leftArrayIndex];
                    leftArrayIndex++;
                }
                mergeArrayIndex++;
            }

            while (leftArrayIndex < leftArray.Length)
            {
                array[mergeArrayIndex] = leftArray[leftArrayIndex];
                leftArrayIndex++;
                mergeArrayIndex++;
            }


            while (rightArrayIndex < rightArray.Length)
            {
                array[mergeArrayIndex] = leftArray[leftArrayIndex];
                rightArrayIndex++;
                mergeArrayIndex++;
            }
        }

    }
}
