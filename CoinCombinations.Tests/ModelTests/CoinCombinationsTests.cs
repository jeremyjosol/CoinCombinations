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
    public void CalcChange_CreatesListOfChangeType_Void()
    {
    Coins.CalcChange(67);
    List<int> expected = new List<int> { 2, 1, 1, 2 };
    CollectionAssert.AreEqual(expected, Coins._results);
    }
  }
}

