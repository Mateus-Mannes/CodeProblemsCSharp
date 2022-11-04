namespace ArrayAndStrings;
public static class IsUnique {
    ///<summary>Runs in O(n^2) time without adicitonal data structure</summary>
    public static Boolean Run1(char[] word){
        for(int i = 0; i < word.Length; i++){
            for(int j = i + 1; j < word.Length; j++){
                if(word[i] == word[j]) return false;
            }
        }
        return true;
    }

    ///<summary>Runs in O(n) time using hash table</summary>
    public static Boolean Run2(char[] word){
        var hashTable = new HashSet<char>(); 
        for(int i = 0; i < word.Length; i++){
            if(hashTable.Contains(word[i])) return false;
            hashTable.Add(word[i]);
        }
        return true;
    }
}