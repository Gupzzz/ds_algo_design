namespace VScode
{
    public class ArrayRotationC
    {
        public int[] ArrayRotationUsingGCD(int[] arr, int d)
        {
            int i, j, k, temp, n = arr.Length;
            for (i = 0; i < gcd(d, n); i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
            return arr;
        }
        public int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }
    }
}