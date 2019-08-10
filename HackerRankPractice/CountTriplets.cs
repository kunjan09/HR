using System;
using System.Collections.Generic;

namespace HackerRankPractice
{
    class CountTriplets
    {

        public long countTriplets(List<long> arr, long r)
        {
            Dictionary<long, long> counts = new Dictionary<long, long>();
            Dictionary<long, long> pairs = new Dictionary<long, long>();

            long tripletCount = 0;

            for (long i = arr.Count - 1; i > -1; i--)
            {
                long num = arr[(int)i];
                long numR = num * r;

                if (pairs.ContainsKey(numR))
                {
                    tripletCount += pairs[numR];
                }

                if (counts.ContainsKey(numR))
                {
                    if (pairs.ContainsKey(num))
                        pairs[num] += counts[numR];
                    else
                        pairs[num] = counts[numR];
                }


                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }


            return tripletCount;
        }

    }
}
