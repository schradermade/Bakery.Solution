using System.Collections.Generic;
using System;

namespace Inventory.Models
{
  public class Bread
  {
    public string Flavor { get; }

    public string Message { get; set; }

    private static List<Bread> _instances = new List<Bread> {};

    public Bread(string flavor, string message)
    {
      Flavor = flavor;
      Message = message;
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