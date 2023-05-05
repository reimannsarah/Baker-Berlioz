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
      Pastry pastryOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }
  }
}