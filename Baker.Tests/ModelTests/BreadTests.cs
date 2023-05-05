using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Baker.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }
  }
}