using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm
{
    class BinarySearch
    {

        public List<int> Arr { get; set; }

        public List<int> GetList()
        {
            Arr = new List<int>
            {
                1,
                2, 
                3, 
                4
            };
            return Arr;
        }

        public int BSearch(int item)
        {
            int low = 0;
            int high = GetList().Count - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = GetList()[mid];
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
