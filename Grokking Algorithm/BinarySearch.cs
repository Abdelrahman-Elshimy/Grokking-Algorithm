using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm
{
    class BinarySearch
    {

       

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
