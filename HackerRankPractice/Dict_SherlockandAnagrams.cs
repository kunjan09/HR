using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HackerRankPractice
{
    class Dict_SherlockandAnagrams
    {
        List<string> retVal = new List<string>();
        public int sherlockAndAnagrams(string s)
        {
            int match = 0;


            Dictionary<string, int> anag = new Dictionary<string, int>();

            var subS = permute(s.ToCharArray(),0,s.Length-1);
            foreach (string str in subS)
            {

                if (anag.ContainsKey(str))
                {
                    anag[str] += 1;
                    match++;
                }
                else
                    anag.Add(str, 1);
            }



            return match;
        }



        //private List<string> GetAllSubString(string str)
        //{
        //    List<string> retVal = new List<string>();


        //    for (int i = 1; i < str.Length; i++)
        //    {
        //        for (int start = 0; start <= str.Length - i; start++)
        //        {
        //            var substrArr = str.Substring(start, i).ToCharArray();
        //            Array.Sort(substrArr);
        //            var p = new string(substrArr);
        //            retVal.Add(p);
        //            Debug.WriteLine(p);
        //        }
        //    }
        //    return retVal;
        //}



         List<string> permute(char[] arry, int i, int n)
        {
            
           
            int j;
            if (i == n)
                retVal.Add(new string(arry));
            else
            {
                for (j = i; j <= n; j++)
                {
                    swap(ref arry[i], ref arry[j]);
                    permute(arry, i + 1, n);
                    swap(ref arry[i], ref arry[j]); //backtrack
                }
            }

            return retVal;
        }

         void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }




    }
}
