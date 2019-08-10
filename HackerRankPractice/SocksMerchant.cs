using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class SocksMerchant
    {
        public  int sockMerchant(int n, int[] ar)
        {
            int totalPairs = 0;
            HashSet<int> socks = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (socks.Contains(ar[i]))
                {
                    socks.Remove(ar[i]);
                    totalPairs = totalPairs + 1;
                }
                else
                    socks.Add(ar[i]);

            }
            return totalPairs;

        }
    }
}
