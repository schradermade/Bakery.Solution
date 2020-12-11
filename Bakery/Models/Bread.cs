using System.Collections.Generic;
using System;

namespace Inventory.Models
{
  public class Bread
  {
    public string Flavor { get; }

    public string Message { get; set; }

    public string Quantity { get; set; }

    private static List<Bread> _instances = new List<Bread> {};

    private static List<Bread> breadOrder = new List<Bread> {};

    public Bread(string flavor)
    {
      Flavor = flavor;
      Message = "Our flavor bread of the day is Sourdough!";
      breadOrder.Add(this);
    }

    public Bread(string flavor, string quantity)
      : this(flavor)
    {
      Message = "Our flavor bread of the day is Sourdough!";
      Quantity = quantity;
    }



    // public string GetOrder()
    // {
      
    // }

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