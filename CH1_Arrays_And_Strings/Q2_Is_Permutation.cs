namespace ArrayAndStrings;
public static class IsPermutation {
    ///<summary>Runs in O(n log n) time O(1) extra memory</summary>
    public static Boolean Run1(char[] word1, char[] word2){
        if(word1.Length != word2.Length) return false;
        Array.Sort(word1);
        Array.Sort(word2);
        for(int i = 0; i < word1.Length; i++){
            if(word1[i] != word2[i]) return false;
        }
        return true;
    }

    ///<summary>Runs in O(n) time O(n) extra memory</summary>
    public static Boolean Run2(char[] word1, char[] word2){
        if(word1.Length != word2.Length) return false;

        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        for(int i = 0; i < word1.Length; i++){
            AddToDict(dict1, word1[i]);
            AddToDict(dict2, word2[i]);
        }

        for(int i = 0; i < word1.Length; i++){
            if(!dict2.ContainsKey(word1[i])) return false;
            if(dict2[word1[i]] != dict1[word1[i]]) return false;
        }
        return true;
    }

    private static void AddToDict(Dictionary<char, int> dict, char value){
        if(dict.ContainsKey(value)) dict[value]++;
        else dict.Add(value, 1);
    }
}