using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void GetPastry_CreatesInstanceOfItem_Pastry()
    {
      Pastry newPastry = new Pastry("donut", 3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
    [TestMethod]
    public void CalcOrderCost_ReturnsTotalCost_Cost()
    {
      // Arrange
      string flavor = "Glazed";
      int price = 3;
      int OrderCost = 10;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(4);
      // Assert
      Assert.AreEqual(OrderCost, result);
    }

    [TestMethod]
    public void SetPastryFlavor_SetsFlavor_String()
    {
    // Arrange
    string flavor = "glazed";
    Pastry newPastry = new Pastry(flavor, 2);
    // Act
    string result = newPastry.Flavor;
    //Assert
    Assert.AreEqual(flavor, result);
    }
  }
}