using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void GetBread_CreatesInstanceOfItem_Bread()
    {
      Bread newBread = new Bread("flavor", 2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadFlavor_ReturnsFlavor_String()
    {
      // Arrange
      string flavor = "Sourdough";
      Bread newBread = new Bread(flavor, 2);

      // Act
      string result = newBread.Flavor;

      // Assert
      Assert.AreEqual(flavor, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Bread newBread = new Bread("plain", 5);
      double result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetOrder_ReturnOrder_String()
    {
      // Arrange
      List<Bread> newOrder = new List<Bread> { };

      // Act
      List<Bread> result = Bread.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void CalcOrderCost_ReturnsTotalCost_Cost()
    {
    // Arrange
    string flavor = "Plain";
    int price = 5;
    int OrderCost = 15;
    Bread newBread = new Bread(flavor, price);
    // Act
    double result = newBread.CalculateOrderCost(4);
    // Assert
    Assert.AreEqual(OrderCost, result);
    }
  }
}

