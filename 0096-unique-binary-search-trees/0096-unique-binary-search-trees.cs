public class Solution {
    public int NumTrees(int n) {
        return (int)(Factorial(2 * n) / (Factorial(n + 1) * Factorial(n)));
    }
    public BigInteger Factorial(int i){
            if(i == 0 || i == 1) return 1;
            return i*Factorial(i-1);
    }
}