namespace ArrayAndStrings;
public static class URLfy {
    ///<summary>Runs in O(n)</summary>
    public static void Run(char[] phrase, int lenght){
        int spaces =  CountSpaces(phrase);
        int spacePosition = -1;
        for(int i = lenght-1; i >= 0; i--){
            if(phrase[i] == ' ' || i == 0){
                if(spacePosition == -1) continue;
                if(spacePosition == phrase.Length){
                    spaces--;
                    continue;
                }
                phrase[spacePosition] = '%';
                phrase[spacePosition + 1] = '2';
                phrase[spacePosition + 2] = '0';
                spaces--;
                continue;
            }
            int newIndex = i + spaces*2;
            if(phrase[i + 1] == ' ') spacePosition = newIndex + 1;
            phrase[newIndex] = phrase[i];
        }
        Console.WriteLine(phrase);
    }

    private static int CountSpaces(char[] phrase){
        int index = phrase.Length - 1;
        int count = 0;
        while(phrase[index] == ' '){
            index--;
        }
        while(index >= 0){
            if(phrase[index] == ' ') count++;
            index--;
        }
        return count;
    }

}