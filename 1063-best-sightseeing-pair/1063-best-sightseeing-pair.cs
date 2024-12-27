public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int maxLeft = values[0];
        int maxScore = 0;

        for (int j = 1; j < values.Length; j++) {
            maxScore = Math.Max(maxScore, maxLeft + values[j] - j);
            maxLeft = Math.Max(maxLeft, values[j] + j);
        }

        return maxScore;
    }
}