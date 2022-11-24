using System.Text;

namespace ArrayAndStrings;
public static class StringCompression {
    public static char[] Run(char[] chars){
       Dictionary<string, int> dict = new Dictionary<string, int>();
       int position = 0;

       for(int i = 0; i < chars.Length; i++){
        var key  = CharKey(chars[i], position);
        if(!dict.ContainsKey(key)) {
            dict.Add(key, 1);
        } 
        else 
        {
            dict[key]++;
        }
        if(i + 1 != chars.Length && chars[i] != chars[i+1]) position = i+1;
       }

       if (dict.Keys.Count * 2 >= chars.Length) return chars;

       var compressed = new StringBuilder();
       foreach(var pair in dict){
        compressed.Append(pair.Key.First() + pair.Value.ToString());
       }
       return compressed.ToString().ToArray();
    }

    public static string CharKey(char c, int position) {
        return c + position.ToString();
    }

    // Runs without extra memory
    public static char[] Run2(char[] chars){
        var compressed = new StringBuilder();
        int count = 0;
        char letter = chars[0];
        foreach(var c in chars){
            if(c == letter){
                count++;
            }else {
                compressed.Append(letter + count.ToString());
                count = 1;
                letter = c;
            }
        }
        compressed.Append(letter + count.ToString());
        if(compressed.Length >= chars.Length) return chars;
        return compressed.ToString().ToArray();
    }
}