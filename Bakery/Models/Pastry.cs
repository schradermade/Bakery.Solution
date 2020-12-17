using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery
{
  public class Pastry
  {
    public string Flavor { get; set; }
    public double Price { get; set; }
    private static List<Pastry> _instances = new List<Pastry> {};
    private static List<Pastry> _pastryOrder = new List<Pastry> {};
    public Pastry(string flavor, double price)
    {
      Flavor = flavor;
      Price = price;
    }
    public double CalculatePastryOrder(int quantity)
    {
      int numberOfFullSets = quantity / 3;
      int remainingPastries = quantity % 3;
      return (numberOfFullSets * 5) + (remainingPastries * Price);
    }
    public static List<Pastry> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}