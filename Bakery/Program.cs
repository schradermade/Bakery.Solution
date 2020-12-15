using System;
using System.Collections.Generic;


namespace Bakery
{
  public class Programs
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Schrader's Bakery! Bread is $" + Bread.Price +  " per loaf, and Pastries are $2.50 each.");
      Console.WriteLine("press ENTER to order!");
      Console.ReadLine();
      Console.WriteLine("What can we get you?");
      Console.WriteLine("Please Type 'Bread' or 'Pastry' ");
      string placeOrder = Console.ReadLine().ToLower();
      if (placeOrder == "bread")
      {
        Console.WriteLine("Which flavor bread would you like?");
        Console.WriteLine("press ENTER to see our selection!");
        Console.ReadLine();
        Console.WriteLine("Availabe Flavors: Sourdough");
        Console.WriteLine("Please type in one of of the flavor selections listed.");
        string flavor = Console.ReadLine();
        Console.WriteLine("How many loafs of " + flavor + " would you like?");
        string quantity = Console.ReadLine();
        int quantityString = Int32.Parse(quantity);
        int quantityDeals = Int32.Parse(quantity) / 2;
        Bread _breadOrder = new Bread(flavor, quantity);
        Console.WriteLine(_breadOrder.GetOrder());
      }
    }
  }
}