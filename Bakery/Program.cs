using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Programs
  {
    static void Main()
    {
      string flavorBread = "";
      string flavorPastry = "";
      string quantityBreadString = "";
      int quantityBread = 0;
      string quantityPastryString = "";
      int quantityPastry = 0;
      Bread plainBread = new Bread("Plain", 5);
      Pastry donut = new Pastry("Glazed Donut", 2);
      double totalOrderCostBread = 0;
      double totalOrderCostPastry = 0;
      Console.WriteLine("");
      Console.WriteLine("*************************************************");
      Console.WriteLine("**********Welcome to Schrader's Bakery!**********");
      Console.WriteLine("*************************************************");
      Console.WriteLine("");
      Console.WriteLine("> Plain bread: $" + plainBread.Price +  " per loaf | Pastries: $" + donut.Price + " each <");
      Console.WriteLine("");
      Console.WriteLine("Today's Deals:");
      Console.WriteLine("");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $" + plainBread.Price);
      Console.WriteLine("");
      Console.WriteLine("Pastries: Buy 1 for $" + donut.Price + ", or 3 for $5.");
      Console.WriteLine("");
      Console.WriteLine("press ENTER to order!");
      Console.ReadLine();
      Console.WriteLine("Would you like to order bread today? Type 'yes' to order");
      string breadOrder = Console.ReadLine();
      Console.WriteLine("");
      if (breadOrder == "yes")
      {
        Console.WriteLine("Which flavor bread would you like?");
        Console.WriteLine("press ENTER to see our selection!");
        Console.ReadLine();
        Console.WriteLine("Availabe Bread Flavors: Plain");
        Console.WriteLine("Please type in one of of the flavor selections listed.");
        flavorBread = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("How many loafs of " + flavorBread + " bread would you like?");
        Console.WriteLine("");
        quantityBreadString = Console.ReadLine();
        Console.WriteLine("");
        quantityBread = Int32.Parse(quantityBreadString);
        totalOrderCostBread += plainBread.CalculateOrderCost(quantityBread);
      }
      Console.WriteLine("Would you like to order pastries today? Type 'yes' to order");
      string pastryOrder = Console.ReadLine();
      Console.WriteLine("");
      if (pastryOrder == "yes")
      {
        Console.WriteLine("Which flavor pastry would you like?");
        Console.WriteLine("press ENTER to see our selection!");
        Console.ReadLine();
        Console.WriteLine("Available Flavors: Glazed Donut");
        Console.WriteLine("Please type in one of the flavor selections listed.");
        flavorPastry = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("How many " + flavorPastry + "'s would you like?");
        Console.WriteLine("");
        quantityPastryString = Console.ReadLine();
        Console.WriteLine("");
        quantityPastry = Int32.Parse(quantityPastryString);
        totalOrderCostPastry += donut.CalculatePastryOrder(quantityPastry);
      }
      Console.WriteLine("********************************");
      Console.WriteLine("**Schrader's Bakery Reciept:**");
      Console.WriteLine("********************************");
      Console.WriteLine("-");
      Console.WriteLine("Loafs of " + flavorBread + " bread: " + quantityBread + " @ $" + totalOrderCostBread + " total");
      Console.WriteLine("-");
      Console.WriteLine("Savings on daily bread deal!: $" + ((quantityBread * plainBread.Price) - totalOrderCostBread));
      Console.WriteLine("-");
      Console.WriteLine("Number of " + flavorPastry + " pastries: " + quantityPastry + " @ $" + totalOrderCostPastry + " total");
      Console.WriteLine("-");
      Console.WriteLine("Savings from daily pastry deal!: $" + ((quantityPastry * donut.Price) - totalOrderCostPastry));
      Console.WriteLine("-");
      Console.WriteLine("Today's total savings!: $" + ((((quantityPastry * donut.Price) - totalOrderCostPastry)) + ((quantityBread * plainBread.Price) - totalOrderCostBread)) + ".00");
      Console.WriteLine("-");
      Console.WriteLine("Order Total: $" + (totalOrderCostBread + totalOrderCostPastry) + ".00");
      Console.WriteLine("--------------------------------");
    }
  }
}