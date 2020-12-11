using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Inventory.Models;
using System;

namespace Inventory.Tests
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
      Bread newBread = new Bread("flavor", "2");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadType_ReturnsType_String()
    {
      // Arrange
      string flavor = "Sourdough";
      Bread newBread = new Bread(flavor, "2");

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
      Bread newBread = new Bread("Sourdough", "2");

      // Act
      string result = newBread.Message;

      // Assert
      Assert.AreEqual(message, result);
    }

    [TestMethod]
    public void GetOrderQuantity_ReturnsQuantityNumber_Integer()
    {
      // Arrange
      string quantity = "2";
      Bread newBread = new Bread("flavor here", quantity);

      // Act
      string result = newBread.Quantity;

      // Assert
      Assert.AreEqual(quantity, result);
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
  }
}

