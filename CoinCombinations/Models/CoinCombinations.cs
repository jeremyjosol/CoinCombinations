using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class Coins
  {
    public static int[] coinsArray = new int[] { 25, 10, 5, 1 };

    public List<int> _results = new List<int> {}; 

    public int Change { get; set; }

    public Coins(int change)
    {
      Change = change;
    }

    public void CalcChange()
    {
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
