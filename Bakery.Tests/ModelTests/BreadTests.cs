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
      Bread newBread = new Bread();
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
  }
}