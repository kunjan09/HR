namespace HackerRankPractice
{
    class JumpingontheClouds
    {

        public int jumpingOnClouds(int[] c)
        {
            int totalHop = 0;


            for (int i = 0; i < c.Length; i++)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                    i++;

                totalHop++;

            }
            return totalHop - 1;

        }


    }
}
