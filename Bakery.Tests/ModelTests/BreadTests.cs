using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using Inventory.Models;
// using System;

namespace Inventory.TestTools
{
  [TestClass]
  public class BreadTests
  {

    // public void Dispose()
    // {
    //   Bread.ClearAll();
    // }

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
      string message = "Welcome to Schrader's Bakery! Bread is $5 per loaf, and Pastries are $2.50 each. What can we get you?";
      Bread newBread = new Bread(message);

      // Act
      string result = newBread.Message;

      // Assert
      Assert.AreEqual(message, result);
    }
  }
}