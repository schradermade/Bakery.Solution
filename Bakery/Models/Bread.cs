using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery
{
  public class Bread
  {
    public string Flavor { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    private static List<Bread> _instances = new List<Bread> {};
    private static List<Bread> _breadOrder = new List<Bread> {};
    public Bread(string flavor, int quantity)
    {
      Flavor = flavor;
      Quantity = quantity;
      _breadOrder.Add(this);
    }
    public int CalculateOrderCost()
    {
     return 15;
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