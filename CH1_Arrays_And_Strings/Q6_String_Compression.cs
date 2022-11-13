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
}