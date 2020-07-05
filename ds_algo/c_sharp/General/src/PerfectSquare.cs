using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general
{
    class PerfectSquare
    {
        public int CheckPerfectSquare( int n, int left, int right )
        {
            if (right >= left)
            {
                int mid = left + ((right - left) / 2);
                if (mid * mid == n)
                {
                    return mid;
                }
                if (mid * mid > n)
                {
                    return CheckPerfectSquare(n, left, mid - 1);
                }
                return CheckPerfectSquare(n, mid + 1, right);
            }
            return -1;
        }
    }
}
