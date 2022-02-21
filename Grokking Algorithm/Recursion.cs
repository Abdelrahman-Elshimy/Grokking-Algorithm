using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm
{
    class Recursion
    {
        public void CountDown(ref int i)
        {
            i--;
            if(i > 0)
            {
                CountDown(ref i);
            }
          
        }
    }
}
