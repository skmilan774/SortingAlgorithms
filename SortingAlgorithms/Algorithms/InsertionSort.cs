using SortingAlgorithms.Enums;
using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    class InsertionSort : ISortingAlgorithm
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
                { "Best", "O(n)"},
                { "Average", "O(n^2)" },
                { "Worst", "O(n^2)" }
            };
        }

        public Dictionary<string, string> GetSpaceComplexity()
        {
            return new Dictionary<string, string>() {
                { "Best", "O(1)"},
                { "Average", "O(1)" },
                { "Worst", "O(1)" }
            };
        }

        private static int[] SortAsc(int[] array, int arrayLength)
        {
            for(int unSortedSubArrIndex = 1; unSortedSubArrIndex <= arrayLength - 1; unSortedSubArrIndex++)
            {
                int sortedSubArrayIndex = unSortedSubArrIndex - 1;
                int selectedElementFromUnsortedSubArray = array[unSortedSubArrIndex];

                bool flag = false;  //Improvement: If the array is already in sorted order(best case) then there will be no swap and flag will not set

                while (sortedSubArrayIndex >= 0 && array[sortedSubArrayIndex] > selectedElementFromUnsortedSubArray)
                {
                    array[sortedSubArrayIndex + 1] = array[sortedSubArrayIndex];
                    sortedSubArrayIndex--;
                    flag = true;
                }

                if (flag == false)
                    break;

                array[sortedSubArrayIndex + 1] = selectedElementFromUnsortedSubArray;
            }

            return array;
        }


        private static int[] SortDesc(int[] array, int arrayLength)
        {
            for (int unSortedSubArrIndex = 1; unSortedSubArrIndex <= arrayLength - 1; unSortedSubArrIndex++)
            {
                bool flag = false;  //Improvement: If the array is already in sorted order(best case) then there will be no swap and flag will not set
                int sortedSubArrayIndex = unSortedSubArrIndex - 1;
                int selectedElementFromUnsortedSubArray = array[unSortedSubArrIndex];

                while (sortedSubArrayIndex >= 0 && array[sortedSubArrayIndex] < selectedElementFromUnsortedSubArray)
                {
                    array[sortedSubArrayIndex + 1] = array[sortedSubArrayIndex];
                    sortedSubArrayIndex--;
                    flag = true;
                }

                if (flag == false)
                    break;

                array[sortedSubArrayIndex + 1] = selectedElementFromUnsortedSubArray;
            }

            return array;
        }
    }
}
