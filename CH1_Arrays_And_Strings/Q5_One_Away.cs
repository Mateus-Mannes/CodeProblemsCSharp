namespace ArrayAndStrings;
using System;

public static class OneAway {
    // runs in O(N) but with additional O(N) memory and not necessaries loops
    public static Boolean Run(char[] origin, char[] edited){
       
        var hash = new HashSet<char>();
        foreach(var c in origin) hash.Add(c);
        var editedNewCharsCount = edited.Count(x => !hash.Contains(x));

       // might be insertion
       if(origin.Length + 1 == edited.Length){
        if(editedNewCharsCount == 1) return true;
       }

       // might be deletion
       if(origin.Length -1 == edited.Length){
        if(edited.Count(x => !hash.Contains(x)) == 0) return true;
       }

       // might be replace
       if(origin.Length == edited.Length){
        if(edited.Count(x => !hash.Contains(x)) == 1) return true;
       }

       return false;
    }
    // runs in O(N) in one loop without extra memory
    public static bool Run2(char[] origin, char[] edited){
        if(Math.Abs(origin.Length - edited.Length) > 1) return false;

        // get smallest and bigger strings
        var s1 = origin.Length < edited.Length ? origin : edited;
        var s2 = origin.Length < edited.Length ? edited : origin;

        int index1 = 0;
        int index2 = 0;
        bool difference = false;
        
        while(index1 < s1.Length && index2 < s2.Length){
            if(index1 < s1.Length && s1[index1] != s2[index2]){

                if(difference) return false;
                else difference = true;

                if(s1.Length == s2.Length) index1++;
            } else {
                index1++;
            }
            index2++;
        }
        return true;
    }
}