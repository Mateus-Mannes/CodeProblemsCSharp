using System.Collections.Generic;
using System.Linq;

namespace LikedLists;

public static class SumLists {
    // 
    public static LinkedList<int> Run(LinkedList<int> n1, LinkedList<int> n2){
      var sum = ConvertoToInt(n1) + ConvertoToInt(n2);
      return ConvertToList(sum);
    }

    public static int ConvertoToInt(LinkedList<int> list) {
      var ptr = list.First;
      int number = 0;
      var decimalPart = 1;
      while(ptr != null){
        number += ptr.Value * decimalPart;
        decimalPart *= 10;
        ptr = ptr.Next;
      }
      return number;
    }

    public static LinkedList<int> ConvertToList(int number) {
      int decimalParts = GetDecimalParts(number);
      var list = new LinkedList<int>();
      int lastNumber = 0;
      for(int i = 1; i <= decimalParts; i++){
        int remainder;
        Math.DivRem(number, (int)Math.Pow(10, i), out remainder);
        var node = list.AddLast((remainder - lastNumber)/(int)Math.Pow(10, i-1));
        lastNumber = remainder;
      }
      return list;
    }

    public static int GetDecimalParts(int number) {
      int decimalParts = 0;
      int divResult = -1;
      do {
        decimalParts ++;
        int remainder;
        divResult = Math.DivRem(number, (int)Math.Pow(10, decimalParts), out remainder);
      } while(divResult != 0);
      return decimalParts;
    }
}