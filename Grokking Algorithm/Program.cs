using System;
using System.Collections.Generic;

namespace Grokking_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Binary Search Algorithm
            //List<int> List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //BinarySearch binarySearch = new BinarySearch();
            //int result = binarySearch.BSearch(List, 7);
            //Console.WriteLine(result);
            #endregion

            #region Selection Sort Algorithm

            List<int> List = new List<int> { 8, 9, 1, 7, 5, 6, 4, 3, 2 };
            SeclectionSort seclectionSort = new SeclectionSort();
            var sortedArray = seclectionSort.SelectionSorts(List);
            
            foreach(int a in sortedArray)
            {
                Console.WriteLine(a);
            }


            #endregion




        }
    }
}
