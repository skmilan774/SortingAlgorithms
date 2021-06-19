using SortingAlgorithms.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Interfaces
{
    public interface ISortingAlgorithm
    {
        int[] Sort(int[] array, int arrayLength, SortTypes sortType);

        Dictionary<string, string> GetTimeComplexity();

        Dictionary<string, string> GetSpaceComplexity();
    }
}
