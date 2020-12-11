using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Inventory.Models;
using System;

namespace Inventory.TestTools
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
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadType_ReturnsType_String()
    {
      // Arrange
      string flavor = "Sourdough";
      Bread newBread = new Bread(flavor);

      // Act
      string result = newBread.Flavor;

      // Assert
      Assert.AreEqual(flavor, result);
    }

    [TestMethod]
    public void GetWelcomeMessage_ReturnsWelcomeMessage_String()
    {
      // Arrange
      string message = "Our flavor bread of the day is Sourdough!";
      Bread newBread = new Bread("Sourdough");

      // Act
      string result = newBread.Message;

      // Assert
      Assert.AreEqual(message, result);
    }

    [TestMethod]
    public void GetOrderQuantity_ReturnsQuantityNumber_Integer()
    {
      // Arrange
      int quantity = 2;
      Bread newBread = new Bread("Sourdough", 2);

      // Act
      int result = newBread.Quantity;

      // Assert
      Assert.AreEqual(quantity, result);
    }
  }
}

