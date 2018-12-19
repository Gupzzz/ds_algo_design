namespace VScode
{
    public class SumOfKNumbersEqualsSumC
    {
        public bool SumOfKNumbersEqualsSum(int[] arr, int i, int sum)
        {
            bool result = false;
            if(sum == 0)
                return true;
            else if (sum > 0 && i < arr.Length)
            {
                int currentSum = sum - arr[i++];
                result = result || SumOfKNumbersEqualsSum(arr, i, currentSum);
                result = result || SumOfKNumbersEqualsSum(arr, i, sum);  
                return result;
            }  
            return result;
        }
    }
}