using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class CountingValleys
    {

        public static int countingValleys(int n, string s)
        {
            int valleyCount = 0;
            int sum = 0;
            foreach (char c in s.ToCharArray())
            {
                if (c == 'U')
                {
                    if (++sum == 0)
                        valleyCount++;
                }
                else
                    sum--;

                Console.WriteLine("Char {0},  Sum: {1}, ValleyCount: {2}", c, sum, valleyCount);
            }
            Console.WriteLine("Enter to continue:");
            Console.ReadKey();
            return valleyCount;

        }



    }
}
