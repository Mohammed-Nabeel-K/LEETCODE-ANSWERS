public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int min = int.MaxValue;

        // Store the indices of common restaurants from both lists
        foreach (string i in list1) {
            if (list2.Contains(i)) {
                int idx = Array.IndexOf(list1, i) + Array.IndexOf(list2, i);
                
                // If the restaurant already exists, we update the value (no need to use Add)
                dict[i] = idx;  // This works even if the restaurant already exists in the dictionary

                // Update the minimum sum of indices
                if (min > idx) {
                    min = idx;
                }
            }
        }
        
        List<string> arr = new List<string>();
        // Collect all restaurants with the minimum index sum
        foreach (var item in dict) {
            if (item.Value == min) {
                arr.Add(item.Key);
            }
        }

        // Return the result as an array
        return arr.ToArray();
    }
}
