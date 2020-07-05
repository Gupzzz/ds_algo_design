namespace general
{
    class PaintingFenceC
    {
        // https://www.geeksforgeeks.org/painting-fence-algorithm/
        public long countWays(int n, int k)
        {
            // There are k ways to color first post  
            long total = k;
            int mod = 1000000007;

            // There are 0 ways for single post to  
            // violate (same color_ and k ways to  
            // not violate (different color)  
            long same = 0, diff = k;

            // Fill for 2 posts onwards  
            for (int i = 2; i <= n; i++)
            {
                // Current same is same as previous diff  
                same = diff;

                // We always have k-1 choices for next post  
                diff = total * (k - 1);
                diff = diff % mod;

                // Total choices till i.  
                total = (same + diff) % mod;
            }

            return total;
        }
    }
}