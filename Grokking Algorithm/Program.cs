using System;
using System.Collections.Generic;

namespace Grokking_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List = new List<int> {1, 2, 3, 4, 5, 6, 7 ,8 ,9};
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.BSearch(List, 4);
        }
    }
}
