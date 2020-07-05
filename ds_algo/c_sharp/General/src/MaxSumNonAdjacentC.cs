namespace general
{
    class MaxSumNonAdjacentC
    {
        // https://www.geeksforgeeks.org/maximum-sum-such-that-no-two-elements-are-adjacent/
        public int FindMaxSumNonAdjacent(int[] arr, int n)
        {
            int incl = arr[0];
            int excl = 0;
            int excl_new;
            int i;

            for (i = 1; i < n; i++)
            {
                /* current max excluding i */
                excl_new = (incl > excl) ?
                                incl : excl;

                /* current max including i */
                incl = excl + arr[i];
                excl = excl_new;
            }

            /* return max of incl and excl */
            return ((incl > excl) ?
                                incl : excl);
        }
    }
}