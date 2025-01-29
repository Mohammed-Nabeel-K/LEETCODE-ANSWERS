public class MyHashSet {

    private HashSet<int> myHashSet ;
    
    public MyHashSet() {
        myHashSet = new HashSet<int>();
    }
    
    public void Add(int key) {
        myHashSet.Add(key);
    }
    
    public void Remove(int key) {
        myHashSet.Remove(key);
    }
    
    public bool Contains(int key) {
        return myHashSet.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */