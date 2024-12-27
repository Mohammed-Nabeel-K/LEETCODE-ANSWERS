function maxScoreSightseeingPair(values: number[]): number {
    let maxScope:number = 0;
    let maxLeft:number = values[0];

    for(let i=1;i<values.length; i++){
        maxScope = Math.max(maxScope,maxLeft+values[i]-i);
        maxLeft = Math.max(maxLeft, values[i]+i);
    }
    return maxScope;
};