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
    public void GetPrice_ReturnsPastryPrice_Int()
    {
      Pastry newPastry = new Pastry("donut", 5);
      Assert.AreEqual(newPastry.Price, 5);
    }

    [TestMethod]
    public void GetFlavor_ReturnsPastryFlavor_String()
    {
      Pastry newPastry = new Pastry("donut", 5);
      Assert.AreEqual(newPastry.Flavor, "donut");
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
    public void SetPrice_ReturnsPrice_Int()
    {
    Pastry newPastry = new Pastry("glazed", 5);
    double result = newPastry.Price;
    Assert.AreEqual(5, newPastry.Price);
    }
    
    [TestMethod]
    public void SetFlavor_ReturnsFlavor_String()
    {
    Pastry newPastry = new Pastry("donut", 6);
    string result = newPastry.Flavor;
    Assert.AreEqual("donut", newPastry.Flavor);
    }

    [TestMethod]
    public void CalcOrderCostNoDeal_ReturnsTotalCostOne_Cost()
    {
      // Arrange
      string flavor = "Glazed";
      int orderQuantity = 2;
      int price = 2;
      int orderTotal = 2;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }


  }
}