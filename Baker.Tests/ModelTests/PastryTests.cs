using Microsoft.VisualStudio.TestTools.UnitTesting;
using Baker.Models;

namespace Baker.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }
    [TestMethod]
    public void Pastry_CreatesPastryWithPriceAndAmount_Pastry()
    {
      int expected = 4;
      Pastry pastryOrder = new Pastry(4);
      Assert.AreEqual(expected, pastryOrder.OrderAmount);
    }
    [TestMethod]
    public void CalculateTotal_ReturnsOrderPriceUsingInputtedOrderAmount_Int()
    {
      int expected = 12;
      Pastry pastryOrder = new Pastry(8);
      Assert.AreEqual(expected, pastryOrder.CalculateTotal());
    }
  }
}