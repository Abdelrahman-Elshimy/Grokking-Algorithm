using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm
{
    class BinarySearch
    {
        // O Notation of binary search
        // O(log n)

        #region  Hints
        // Binary search is a lot faster than simple search
        // O(log n) is faster than O(n), but it gets a lot faster once the list of items you are searching through grows.
        // Algorithm speed isn't measured in seconds.
        // Algorithm times are measured in terms of growth of an algorithm
        // Algorithm times are written in Big O notation.
        #endregion

        public int BSearch(List<int> arr, int item)
        {
            int low = 0;
            int high = arr.Count - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arr[mid];
                if (guess == item)
                    return mid;
                if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return 0;
        }
    }
}
