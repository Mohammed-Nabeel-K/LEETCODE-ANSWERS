class Solution {
    public int maxScoreSightseeingPair(int[] values) {
        int maxScope = 0;
        int maxLeft = values[0];
        for (int i = 1; i<values.length; i++){
            maxScope = Math.max(maxScope, maxLeft+values[i] - i);
            maxLeft = Math.max(maxLeft, values[i]+i);
        }
        return maxScope;
    }
}