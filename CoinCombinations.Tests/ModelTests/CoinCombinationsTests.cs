using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations.Models;
using System;
using System.Collections.Generic;

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

  [TestMethod]
  public void CalcChange_SetsValueOfChange_Int()
  {
    Coins coins = new Coins(67);
    int newChangeNumber = 34;
    coins.Change = newChangeNumber;
    Assert.AreEqual(newChangeNumber, coins.Change);

  }

  [TestMethod]
  public void CalcChange_CreatesListOfChangeType_Void()
  {
    Coins coins = new Coins(67);
    coins.CalcChange();
    List<int> expected = new List<int> { 2, 1, 1, 2 };
    CollectionAssert.AreEqual(expected, coins._results);
  }
  }
}

