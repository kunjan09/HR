using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class Array_MaxSum
    {
        

        public  int maxSubsetSum(int[] arr)
        {

            int inc = arr[0];
            int exc = 0;
            int new_exc;

            for (int i = 1; i < arr.Length; i++)
            {
                new_exc = exc;
                exc = Math.Max(exc, inc);
                inc = arr[i] + new_exc;
            }
            return Math.Max(exc, inc);
            return 0;
        }
    }
}
