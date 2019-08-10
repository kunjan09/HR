using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class RepeatedString
    {

        public long repeatedString(string s, long n)
        {
            long accurenceCount = 0;

            if (s.Length == 0)
                return 0;
            if (s.Length == 1 && s[0] == 'a')
                return n;
            int aCountInString = getCoutner(s, 'a');

            var quotient = n / s.Length;
            var remainder = n % s.Length;


            var extra=getCoutner(s, 'a', remainder);
            accurenceCount = (quotient * aCountInString) + extra;



            return accurenceCount;

        }

        private int getCoutner(string s, char v, long lenght = -1)
        {
            int counter = 0;

            if (lenght == -1)
                lenght = s.Length;

           for(int i=0;i< lenght; i++)
                if (s[i] == v)
                    counter++;
            return counter;
        }
    }
}
