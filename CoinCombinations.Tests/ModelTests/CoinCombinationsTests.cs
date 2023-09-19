using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations.Models;
using System;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinsTests
  {
  [TestMethod]
  public void CalcChange_GetValueOfChange_Int()
  {
    int userInput = 67;
    Coins coins = new Coins(userInput);
    int value = coins.Change;
    Assert.AreEqual(userInput, value);

    }
  }
}
