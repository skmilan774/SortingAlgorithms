using SortingAlgorithms.Algorithms;
using SortingAlgorithms.Enums;
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

            Console.WriteLine("***Sorting Algorithms***");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" 1. Selection sort");
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

            switch(algoritmType)
            {
                case SortAlgorithmTypes.Selection:
                    SelectionSort.Sort(intArray, intArray.Length, Enums.SortTypes.Asc);
                    timeCompexity = SelectionSort.GetTimeComplexity();
                    spaceComplexity = SelectionSort.GetSpaceComplexity();
                    break;

                default:
                    SelectionSort.Sort(intArray, intArray.Length, Enums.SortTypes.Asc);
                    break;

            }

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
