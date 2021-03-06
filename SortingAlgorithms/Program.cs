using SortingAlgorithms.Algorithms;
using SortingAlgorithms.Enums;
using SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> timeCompexity = new Dictionary<string, string>();
            Dictionary<string, string> spaceComplexity = new Dictionary<string, string>();
            Enums.SortTypes sortType = SortTypes.Asc;

            Console.WriteLine("***Sorting Algorithms***");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" 1. Selection sort");
            Console.WriteLine(" 2. Bubble sort");
            Console.WriteLine(" 3. Insertion sort");
            Console.WriteLine(" 4. Merge sort");
            Console.WriteLine("-------------------------");
            Console.WriteLine("\n*Press the searial number from the above to select sorting algorithm: ");

            SortAlgorithmTypes algoritmType;
            if (Enum.TryParse(Console.ReadLine(), out algoritmType) == false)
            {
                algoritmType = SortAlgorithmTypes.Selection;
                Console.WriteLine("Wrong input. Proceeding with selection sort.");
            }

            Console.WriteLine("\nEnter the array values by space separated and press enter: ");
            Regex regex = new Regex(@"\s");
            string[] strArray = regex.Split(Console.ReadLine());

            int[] intArray = new int[strArray.Length];

            for(int i = 0; i< strArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(strArray[i]);
            }

            ISortingAlgorithm sortProvider;

            switch (algoritmType)
            {
                case SortAlgorithmTypes.Selection:
                    sortProvider = new SelectionSort();
                    break;

                case SortAlgorithmTypes.Bubble:
                    sortProvider = new BubbleSort();
                    break;

                case SortAlgorithmTypes.Insertion:
                    sortProvider = new InsertionSort();
                    break;

                case SortAlgorithmTypes.Merge:
                    sortProvider = new MergeSort();
                    break;

                default:
                    sortProvider = new SelectionSort();
                    break;

            }

            sortProvider.Sort(intArray, intArray.Length, sortType);
            timeCompexity = sortProvider.GetTimeComplexity();
            spaceComplexity = sortProvider.GetSpaceComplexity();

            //Printing the output to the console
            Console.Write("\nSorted Array(Order:Asc): ");
            for(int i = 0; i < intArray.Length; i ++)
            {
                Console.Write($"{intArray[i]} ");
            }

            Console.WriteLine("\n\nTime Complexity:");
            Console.WriteLine("-----------------");
            foreach (KeyValuePair<string, string> keyValuePair in timeCompexity)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }

            Console.WriteLine("\n\nSpace Complexity:");
            Console.WriteLine("------------------");
            foreach (KeyValuePair<string, string> keyValuePair in spaceComplexity)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }

            Console.ReadLine();
        }
    }
}
