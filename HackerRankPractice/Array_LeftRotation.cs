namespace HackerRankPractice
{
    class Array_LeftRotation
    {
        public int[] rotLeft(int[] a, int d)
        {
            
            if (d > a.Length)
                d = d % a.Length;
            if (d == a.Length || d==0)
                return a;



            int[] retArray = new int[a.Length];
            int i = 0;


            for (int start = d; start < a.Length; start++)
            {
                retArray[i] = a[start];
                i++;
            }

            for (int start = 0; start < d; start++)
            {
                retArray[i] = a[start];
                i++;
            }
            return retArray;


        }
    }
}
