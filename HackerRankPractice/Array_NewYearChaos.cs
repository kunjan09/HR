using System;

namespace HackerRankPractice
{
    class Array_NewYearChaos
    {
        public string minimumBribes(int[] q)
        {
            string returnString = "Too chaotic";

            int totalBribes = 0;

            int[] idealQueue = new int[q.Length];
            for (int i = 1; i <= q.Length; i++)
            {

                idealQueue[i - 1] = i;
            }


            for (int i = 0; i < q.Length; i++)
            {
                int tmpBribe;
                // if (q[i] > idealQueue[i])
                //{
                tmpBribe = q[i] - idealQueue[i];
                if (tmpBribe > 2)
                {
                    Console.WriteLine(returnString);
                    return returnString;
                    break;
                }
                //Console.WriteLine("Position_i:{0} Value_q[i]: {1} IdealValue: {2}", i,q[i].ToString(),idealQueue[i].ToString() );

                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        totalBribes++;


               // totalBribes += tmpBribe;
                //}
            }
            Console.WriteLine(totalBribes);
            return totalBribes.ToString();


        }
    }
}
