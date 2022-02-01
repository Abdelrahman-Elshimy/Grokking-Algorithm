using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm
{
    class SeclectionSort
    {
        // O(n^2)

        // Find the smallest index in the array
        public int FindSmallest(List<int> arr)
        {
            var smallest = arr[0];
            var smallest_index = 0;
            
            for(int i =0; i < arr.Count; i++)
            {
                if(arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallest_index = i;
                }
            }
            return smallest_index;
        }

        public List<int> SelectionSorts(List<int> arr)
        {
            List<int> newArr = new List<int>();
            var len = arr.Count();
            for (int i = 0; i < len; i++)
            {
                var smallest = FindSmallest(arr);
                newArr.Add(arr[smallest]);
                arr.Remove(arr[smallest]);
            }
            return newArr;
        }

    }
}
