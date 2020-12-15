using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery
{
  public class Bread
  {
    public string Flavor { get; set; }
    public string Quantity { get; set; }
    public static int Price 
    {  get
      {
        return 10;
      } 
    }  
    private static List<Bread> _instances = new List<Bread> {};
    private static List<Bread> _breadOrder = new List<Bread> {};
    public Bread(string flavor, string quantity)
    {
      Flavor = flavor;
      Quantity = quantity;
      _breadOrder.Add(this);
    }
    public string GetOrder()
    {
      return 
      "Order Details: " + Quantity + " loafs of " + Flavor +
      " bread @ " +  "$" + Price + 
      " per loaf. Total: $" + (Price * Int32.Parse(Quantity)) 
      + " dollars.";
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