namespace ArrayAndStrings;
public static class StringRotation {
    ///<summary></summary>
    public static Boolean Run(char[] word1, char[] word2){
        if(word1.Length != word2.Length) return false;

        var dict1 = new Dictionary<char, int>();
        foreach(var c in word1) AddToDict(dict1, c);

        var dict2 = new Dictionary<char, int>();
        foreach(var c in word2) AddToDict(dict2, c);

        foreach(var c in word1)
            if(dict1[c] != dict2[c]) return false;

        for(int i = 0; i < word2.Length; i++)
            if(word2[i] == word1[0])
                if(IsRotation(word1, word2, i)) return true;
        
        return false;
    }

    private static bool IsRotation(char[] word1, char[] word2, int startPoint){
        for(int i = 0; i < word1.Length; i++){
            if(word1[i] != word2[startPoint]) return false;
            if(startPoint == word1.Length - 1) startPoint = 0;
            else startPoint ++;
        }
        return true;
    }

    ///<summary>Runs in O(n) time O(n) extra memory</summary>
    private static void AddToDict(Dictionary<char, int> dict, char value){
        if(dict.ContainsKey(value)) dict[value]++;
        else dict.Add(value, 1);
    }
}