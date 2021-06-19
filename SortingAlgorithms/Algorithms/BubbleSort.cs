using SortingAlgorithms.Enums;
using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    public class BubbleSort : ISortingAlgorithm
    {
        /// <summary>
        /// The methods will return the sorted array.
        /// Time complexity = O(n^2) for all the cases(best/average/worst) and Space complexity = O(1)
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
            for (int outerPointer = 0; outerPointer < (arrayLength - 1); outerPointer++)
            {
                bool flag = false;  //Improvement: If the array is already in sorted order(best case) then there will be no swap and flag will not set
                for (int innerPointer = 0; innerPointer < arrayLength -1; innerPointer++)
                {
                    if (array[innerPointer] > array[innerPointer + 1])
                    {
                        int temp = array[innerPointer +1];
                        array[innerPointer + 1] = array[innerPointer];
                        array[innerPointer] = temp;
                        flag = true;
                    }                                        
                }

                if (flag == false)
                    break;
            }

            return array;
        }


        private static int[] SortDesc(int[] array, int arrayLength)
        {
            for (int outerPointer = 0; outerPointer < (arrayLength - 1); outerPointer++)
            {
                bool flag = false;  //Improvement: If the array is already in sorted order(best case) then there will be no swap and flag will not set
                for (int innerPointer = 0; innerPointer < arrayLength - 1; innerPointer++)
                {
                    if (array[innerPointer] < array[innerPointer + 1])
                    {
                        int temp = array[innerPointer + 1];
                        array[innerPointer + 1] = array[innerPointer];
                        array[innerPointer] = temp;
                        flag = true;
                    }
                }

                if (flag == false)
                    break;
            }

            return array;
        }
    }
}
