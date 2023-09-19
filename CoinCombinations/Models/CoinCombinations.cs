using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class Coins
  {
    public static int[] coinsArray = new int[] { 25, 10, 5, 1 };

    public static List<int> _results = new List<int> {}; 

    public static int Change { get; set; }
    public static void CalcChange(int change)
    {
      Change = change;
      
      int removedChange;
      int result;

      for (int i = 0; i < coinsArray.Length; i++)
      {
        result = Change / coinsArray[i];
        _results.Add(result);
        removedChange = coinsArray[i] * result;
        Change = Change - removedChange;
      }
    }
  }
}
