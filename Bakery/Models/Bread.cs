using System.Collections.Generic;
using System;
using Inventory;

namespace Inventory.Models
{
  public class Bread
  {
    public string Flavor { get; }

    public string Message { get; set; }

    public string Quantity { get; set; }

    private static List<Bread> _instances = new List<Bread> {};

    private static List<Bread> _breadOrder = new List<Bread> {};

    public Bread(string flavor)
    {
      Flavor = flavor;
      Message = "Our flavor bread of the day is Sourdough!";
      _breadOrder.Add(this);
    }

    public Bread(string flavor, string quantity)
      : this(flavor)
    {
      Message = "Our flavor bread of the day is Sourdough!";
      Quantity = quantity;
    }

    public string GetOrder()
    {
      return "tests";
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