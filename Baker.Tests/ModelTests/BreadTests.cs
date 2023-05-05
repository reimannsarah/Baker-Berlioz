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
      int orderAmount = 4;
      int expected = 4;
      Bread breadOrder = new Bread(orderAmount);
      Assert.AreEqual(expected, breadOrder.GetOrderAmount());
    }
  }
}