public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        int GetColor(string a){
            int column = a[0]+'a'+1;
            int row = a[1]+'0';
            return (column+row)%2;

        }
        return GetColor(coordinate1) == GetColor(coordinate2);
    }
}