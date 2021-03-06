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
      // Arrange
      Pastry newPastry = new Pastry("donut", 3);
      // Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsPastryPrice_Int()
    {
      // Arrange
      Pastry newPastry = new Pastry("donut", 5);
      // Assert
      Assert.AreEqual(newPastry.Price, 5);
    }
    [TestMethod]
    public void GetFlavor_ReturnsPastryFlavor_String()
    {
      // Arrange
      Pastry newPastry = new Pastry("donut", 5);
      // Assert
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
    // Arrange
    Pastry newPastry = new Pastry("glazed", 5);
    // Act
    double result = newPastry.Price;
    // Assert
    Assert.AreEqual(5, newPastry.Price);
    }
    [TestMethod]
    public void SetFlavor_ReturnsFlavor_String()
    {
    // Arrange
    Pastry newPastry = new Pastry("donut", 6);
    // Act
    string result = newPastry.Flavor;
    // Assert
    Assert.AreEqual("donut", newPastry.Flavor);
    }
    [TestMethod]
    public void CalcOrderCostOneItem_ReturnsTotalDiscountNo_Total()
    {
      // Arrange
      string flavor = "Glazed";
      int orderQuantity = 1;
      int price = 2;
      int orderTotal = 2;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostTwoItems_ReturnsTotalDiscountNo_Cost()
    {
      // Arrange
      string flavor = "Glazed";
      int orderQuantity = 2;
      int price = 2;
      int orderTotal = 4;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostThreeItems_ReturnsTotalDiscountYes_Cost()
    {
      // Arrange
      string flavor = "Glazed";
      int orderQuantity = 3;
      int price = 2;
      int orderTotal = 5;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostFourItems_ReturnsTotalDiscountYes_Cost()
    {
      // Arrange
      string flavor = "Glazed";
      int orderQuantity = 4;
      int price = 2;
      int orderTotal = 7;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalcOrderCostFiveItems_ReturnsTotalDiscountYes_Cost()
    {
      // Arrange
      string flavor = "Glazed";
      int orderQuantity = 5;
      int price = 2;
      int orderTotal = 9;
      Pastry newPastry = new Pastry(flavor, price);
      // Act
      double result = newPastry.CalculatePastryOrder(orderQuantity);
      // Assert
      Assert.AreEqual(orderTotal, result);
    }
  }
}