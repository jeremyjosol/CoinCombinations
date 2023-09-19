using System;

namespace CoinCombinations.Models
{
  public class Coins
  {
    public static int[] coinsArray = new int[] { 25, 10, 5, 1 };

    public int Change { get; set; }

    public CalcChange(int change)
    {
      Change = change;
    }
  }
}

