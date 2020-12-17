using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Programs
  {
    static void Main()
    {
      Bread plainBread = new Bread("Plain", 5);
      Pastry donut = new Pastry("Glazed Donut", 2);
      double totalOrderCost = 0;
      Console.WriteLine("Welcome to Schrader's Bakery! Plain bread is $" + plainBread.Price +  " per loaf, and Pastries are " + donut.Price + " each.");
      Console.WriteLine("press ENTER to order!");
      Console.ReadLine();
      Console.WriteLine("Would you like to order bread today? Type 'yes' to order");
      string breadOrder = Console.ReadLine();
      if (breadOrder == "yes")
      {
        Console.WriteLine("Which flavor bread would you like?");
        Console.WriteLine("press ENTER to see our selection!");
        Console.ReadLine();
        Console.WriteLine("Availabe Flavors: Plain");
        Console.WriteLine("Please type in one of of the flavor selections listed.");
        string flavor = Console.ReadLine();
        Console.WriteLine("How many loafs of " + flavor + " would you like?");
        string quantityString = Console.ReadLine();
        int quantity = Int32.Parse(quantityString);
        totalOrderCost += plainBread.CalculateOrderCost(quantity);
      }
      Console.WriteLine("Would you like to order pastries today? Type 'yes' to order");
      string pastryOrder = Console.ReadLine();
      if (pastryOrder == "yes")
      {
        Console.WriteLine("Which flavor pastry would you like?");
        Console.WriteLine("press ENTER to see our selection!");
        Console.ReadLine();
        Console.WriteLine("Available Flavors: Glazed Donut");
        Console.WriteLine("Please type in one of the flavor selections listed.");
        string flavor = Console.ReadLine();
        Console.WriteLine("How many " + flavor + "'s would you like?");
        string quantityString = Console.ReadLine();
        int quantity = Int32.Parse(quantityString);
        totalOrderCost += donut.CalculateOrderCost(quantity);
      }
      Console.WriteLine(totalOrderCost);
    }
  }
}