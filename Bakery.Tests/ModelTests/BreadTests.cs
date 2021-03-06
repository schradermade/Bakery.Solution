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
    public void CalcOrderCostOneItem_ReturnsTotalCost_Cost()
    {
    // Arrange
      string flavor = "Plain";
      int orderNumber = 1;
      int price = 5;
      int orderTotal = 5;
      Bread newBread = new Bread(flavor, price);
    // Act
      double result = newBread.CalculateOrderCost(orderNumber);
    // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void SetPrice_ReturnsPrice_Int()
    {
    // Arrange
    Bread newBread = new Bread("glazed", 6);
    // Act
    double result = newBread.Price;
    // Assert
    Assert.AreEqual(6, newBread.Price);
    }
    [TestMethod]
    public void SetFlavor_ReturnsFlavor_String()
    {
    // Arrange
    Bread newBread = new Bread("plain", 6);
    // Act
    string result = newBread.Flavor;
    // Assert
    Assert.AreEqual("plain", newBread.Flavor);
    }
    [TestMethod]
    public void CalcOrderCostOneItem_ReturnsTotalNoDiscount_Cost()
    {
      // Arrange
      string flavor = "Plain";
      int orderNumber = 1;
      int price = 5;
      int orderTotal = 5;
      Bread newBread = new Bread(flavor, price);
      // Act
      double result = newBread.CalculateOrderCost(orderNumber);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostTwoItems_ReturnsTotalNoDiscount_Total()
    {
      // Arrange
      string flavor = "Plain";
      int orderQuantity = 2;
      int price = 5;
      int orderTotal = 10;
      Bread newBread = new Bread(flavor, price);
      // Act
      double result = newBread.CalculateOrderCost(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostThreeItems_ReturnsTotalWithDiscount_Total()
    {
      // Arrange
      string flavor = "Plain";
      int orderQuantity = 3;
      int price = 5;
      int orderTotal = 10;
      Bread newBread = new Bread(flavor, price);
      // Act
      double result = newBread.CalculateOrderCost(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostFourItems_ReturnsTotalWithDiscount_Total()
    {
      // Arrange
      string flavor = "Plain";
      int orderQuantity = 4;
      int price = 5;
      int orderTotal = 15;
      Bread newBread = new Bread(flavor, price);
      // Act
      double result = newBread.CalculateOrderCost(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostFiveItems_ReturnsTotalWithDiscount_Total()
    {
      // Arrange
      string flavor = "Plain";
      int orderQuantity = 5;
      int price = 5;
      int orderTotal = 20;
      Bread newBread = new Bread(flavor, price);
      // Act
      double result = newBread.CalculateOrderCost(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
  }
}

