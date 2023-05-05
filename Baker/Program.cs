using System;
using Baker.UserInterfaceModels;
using Baker.Models;

namespace Baker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to...");
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("MENU");
      Console.WriteLine("Bread $5");
      Console.WriteLine("Buy 2 loaves, get 1 free");
      Console.WriteLine("Pastries $2");
      Console.WriteLine("Buy 4, get 1 free");
      Console.WriteLine("Place an order? (y/n)");
      string input = Console.ReadLine();
      if (input == "y")
      {
        int orderTotal = Order();
        Console.WriteLine($"Your order comes to ${orderTotal}");
      }
    }
    static int Order()
    {
      int orderTotal = 0;
      Bread breadOrder = new Bread();
      Pastry pastryOrder = new Pastry();
      Console.WriteLine("What sounds good?");
      Console.WriteLine("Bread");
      Console.WriteLine("Pastry");
      string choice = Console.ReadLine().ToLower();
      Console.WriteLine("How many?");
      int amount = int.Parse(Console.ReadLine());
      if (choice == "bread")
      {
        breadOrder.OrderAmount = amount;
        breadOrder.CalculateTotal();
        orderTotal += breadOrder.Total;
      }
      else if (choice == "pastry")
      {
        pastryOrder.OrderAmount = amount;
        pastryOrder.CalculateTotal();
        orderTotal += pastryOrder.Total;
      }
      return orderTotal;
    }
  }
}