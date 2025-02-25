public class Solution
{
    public int NumOfSubarrays(int[] arr)
    {
        int oddCount = 0, evenCount = 1; 
        int prefixSum = 0, result = 0;
        int MOD = 1_000_000_007;

        foreach (int num in arr)
        {
            prefixSum += num;

            if (prefixSum % 2 == 0)
            {
                result = (result + oddCount) % MOD;
                evenCount++; 
            }
            else
            {
                result = (result + evenCount) % MOD;
                oddCount++; 
            }
        }

        return result;
    }
}