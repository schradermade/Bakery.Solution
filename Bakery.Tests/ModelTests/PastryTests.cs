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
    public void GetPrice_ReturnsPastryPricem_Price()
    {
      Pastry newPastry = new Pastry("donut", 6);
      Assert.AreEqual(newPastry.Price, 5);
    }

    [TestMethod]
    public void GetPastryFlavor_GetsFlavor_String()
    {
    // Arrange
    string flavor = "glazed";
    Pastry newPastry = new Pastry(flavor, 2);
    // Act
    string result = newPastry.Flavor;
    //Assert
    Assert.AreEqual(flavor, result);
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
  }
}