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
      Assert.AreEqual(expected, pastryOrder.GetOrderAmount());
    }
  }
}