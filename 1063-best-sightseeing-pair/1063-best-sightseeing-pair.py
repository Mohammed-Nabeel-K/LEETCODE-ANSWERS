class Solution:
    def maxScoreSightseeingPair(self, values: List[int]) -> int:
        maxScope = 0
        maxLeft = values[0]
        for i in range(1,len(values)):
            maxScope = max(maxScope,maxLeft+values[i]-i)
            maxLeft = max(maxLeft,values[i]+i)
        
        return maxScope