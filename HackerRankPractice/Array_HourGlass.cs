namespace HackerRankPractice
{
    class _2DArrayDS_HourGlass
    {


        public int hourglassSum(int[][] arr)
        {

            int MaxSum = int.MinValue;


            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < arr[row].GetLength(0) - 2; col++)
                {
                    var tmpSum = arr[row][col] + arr[row][col + 1] + arr[row][col + 2]
                                        + arr[row + 1][col + 1]
                          + arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];

                    if (tmpSum > MaxSum)
                        MaxSum = tmpSum;

                }
            }


            return MaxSum;
        }
    }
}
