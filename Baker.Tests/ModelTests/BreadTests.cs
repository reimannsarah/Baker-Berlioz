using Microsoft.VisualStudio.TestTools.UnitTesting;
using Baker.Models;
using System;

namespace Baker.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(4);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }
    [TestMethod]
    public void Bread_CreatesBreadWithPriceAndNumberOfLoaves_Bread()
    {
      int expected = 4;
      Bread breadOrder = new Bread(4);
      Assert.AreEqual(expected, breadOrder.GetOrderAmount());
    }
    [TestMethod]
    public void CalculateTotal_ReturnsTotalPriceBasedOnInputtedAmount_Int()
    {
      int expected = 20;
      Bread breadOrder = new Bread(6);
      Assert.AreEqual(expected, breadOrder.CalculateTotal());
    }
  }
}