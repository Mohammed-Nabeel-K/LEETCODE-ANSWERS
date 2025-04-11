public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int count = 0;

        for (int i = low; i <= high; i++) {
            string num = i.ToString();
            int len = num.Length;

            if (len % 2 != 0) continue;

            int mid = len / 2;
            int leftSum = 0, rightSum = 0;

            for (int j = 0; j < mid; j++) {
                leftSum += num[j] - '0';
                rightSum += num[j + mid] - '0';
            }

            if (leftSum == rightSum) count++;
        }
        return count;
    }
}