using System.Linq;
using System.Collections.Generic;

public static class Anagrams {
    public static List<string> SortByAnagram(List<string> words){
        List<Tuple<string, double>> list = new List<Tuple<string, double>>();
        foreach(var word in words){
            list.Add(new Tuple<string, double>(word, word.HashString()));
        }
        var sorted = list.OrderBy(x => x.Item2);
        return sorted.Select(x => x.Item1).ToList();
    }

    public static double HashString(this string word){
        int sum = 0;
        foreach(var c in word){
            sum += (int)c;
        }
        return sum/word.Length;
    }
}