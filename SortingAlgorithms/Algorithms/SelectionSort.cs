using SortingAlgorithms.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    class SelectionSort
    {
        /// <summary>
        /// The methods will return the sorted array.
        /// Time complexity = O(n^2) for all the cases(best/average/worst) and Space complexity = O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayLength"></param>
        /// <param name="sortTypes"></param>
        /// <returns>Sorted Array</returns>
        public static int[] Sort(int[] array, int arrayLength, SortTypes sortType = SortTypes.Asc)
        {
            if (sortType == SortTypes.Asc)
                return SortAsc(array, arrayLength);
            else
                return SortDesc(array, arrayLength);
        }

        public static Dictionary<string, string> GetTimeComplexity()
        {
            return new Dictionary<string, string>() {
                { "Best", "O(n^2)"},
                { "Average", "O(n^2)" },
                { "Worst", "O(n^2)" }
            };
        }

        public static Dictionary<string, string> GetSpaceComplexity()
        {
            return new Dictionary<string, string>() {
                { "Best", "O(1)"},
                { "Average", "O(1)" },
                { "Worst", "O(1)" }
            };
        }

        private static int[] SortAsc(int[] array, int arrayLength)
        {
            for (int outerPointer = 0; outerPointer < (arrayLength - 1); outerPointer++)
            {
                for (int innerPointer = (outerPointer + 1); innerPointer < arrayLength; innerPointer++)
                {
                    if (array[outerPointer] > array[innerPointer])
                    {
                        int temp = array[innerPointer];
                        array[innerPointer] = array[outerPointer];
                        array[outerPointer] = temp;
                    }
                }
            }

            return array;
        }


        private static int[] SortDesc(int[] array, int arrayLength)
        {
            for (int outerPointer = 0; outerPointer < (arrayLength - 1); outerPointer++)
            {
                for (int innerPointer = (outerPointer + 1); innerPointer < arrayLength; innerPointer++)
                {
                    if (array[outerPointer] < array[innerPointer])
                    {
                        int temp = array[innerPointer];
                        array[innerPointer] = array[outerPointer];
                        array[outerPointer] = temp;
                    }
                }
            }

            return array;
        }



    }
}
