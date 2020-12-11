using System;
using System.Collections.Generic;
using Inventory.Models;

namespace Inventory
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Schrader's Bakery! Bread is $5 per loaf, and Pastries are $2.50 each.");
      Console.WriteLine("What can we get you?");
      Console.WriteLine("Type 'Bread' or 'Pastry' ");
      string placeOrder = Console.ReadLine().ToLower();
      if (placeOrder == "bread")
      {
        // Console.WriteLine(breadOrder.Message);
        Console.WriteLine("Which flavor bread would you like?");
        Console.WriteLine("Our available flavors are: Sourdough");
        string flavor = Console.ReadLine();
        Console.WriteLine("How many loafs would you like?");
        string quantityString = Console.ReadLine();
        // int quantityInt = int.Parse(quantityString);
        
  
      }
      
    }
  }
}