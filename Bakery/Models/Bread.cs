using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery
{
  public class Bread
  {
    public string Flavor { get; set; }
    public double Price { get; set; }
    private static List<Bread> _instances = new List<Bread> { };
    private static List<Bread> _breadOrder = new List<Bread> { };
    public Bread(string flavor, double price)
    {
      Flavor = flavor;
      Price = price;
      _breadOrder.Add(this);
    }
    public double CalculateOrderCost(int quantity)
    {
      int numberOfFullSets = quantity / 3;
      int billedQuantity = quantity - numberOfFullSets;
      return billedQuantity * Price;
    }
    public static List<Bread> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}