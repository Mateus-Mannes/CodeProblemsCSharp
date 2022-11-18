namespace ArrayAndStrings;
public static class IsPalindromePermutation {
    ///<summary>Runs in O(n) time O(n) extra memory</summary>
    public static Boolean Run(char[] phrase){
        var letterCount = new Dictionary<char, int>();
        foreach(char x in phrase) {
            if(x == ' ') continue;
            var letter = x;
            if(x >= 65 && x <= 90){
                letter = Convert.ToChar(letter + 32);
            }
            AddToDict(letterCount, letter);
        }
        int oddsCount = 0;
        foreach(var element in letterCount){
            if(element.Value % 2 != 0) oddsCount ++;
            if(oddsCount > 1) return false;
        }
        return true;
    }

    ///<summary>Runs in O(n) time O(1) extra memory</summary>
    // flips a bit vector, at the end just one bit can be 1, else it returns false
    public static Boolean Run2(char[] phrase){
        int bitVector = 0; // a-z
        for(int i = 0; i < phrase.Length; i++){
            if(phrase[i] == ' ') continue;
            var letter = phrase[i];
            if(letter >= 65 && letter <= 90) letter = Convert.ToChar(letter + 32);
            int bitVectorPosition = letter - 'a';
            bitVector ^= (1 << bitVectorPosition);
        }
        if(Math.Sqrt(bitVector) % 1 != 0) return false;
        return true;
    }

    private static void AddToDict(Dictionary<char, int> dict, char value){
        if(dict.ContainsKey(value)) dict[value]++;
        else dict.Add(value, 1);
    }
}