namespace ArrayAndStrings;
public static class OneAway {
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
}