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
        int orderTotal = 0;
        int total = Order();
        Console.WriteLine($"Your order comes to ${orderTotal += total}");
        Console.WriteLine("Would you like to order more? (y/n)");
        string orderMore = Console.ReadLine();
        if (orderMore == "y")
        {
          Console.WriteLine($"Your order comes to: ${Order() + total}");
        }
      }
      else
      {
        Console.WriteLine($"{Banner.Bye}");
      }
    }
    static int Order()
    {
      string item = ChooseItem();
      int amount = HowMany(item);
      if (item == "bread")
      {
        Bread breadOrder = new Bread(amount);
        breadOrder.CalculateTotal();
        return breadOrder.Total;
      }
      else if (item == "pastry")
      {
        Pastry pastryOrder = new Pastry(amount);
        pastryOrder.CalculateTotal();
        return pastryOrder.Total;
      }
      else
      {
        return 0;
      }
    }
    static string ChooseItem()
    {
      Console.WriteLine("What sounds good?");
      Console.WriteLine("Bread");
      Console.WriteLine("Pastry");
      string choice = Console.ReadLine().ToLower();
      return choice;
    }
    static int HowMany(string selection)
    {
      if (selection == "bread")
      {
        Console.WriteLine("How many loaves would you like?");
        return int.Parse(Console.ReadLine());
      }
      else if (selection == "pastry")
      {
        Console.WriteLine("How many pastries would you like?");
        return int.Parse(Console.ReadLine());
      }
      else
      {
        Console.WriteLine("Please select from the available options");
        return HowMany(selection);
      }
    }
    // static void OrderMore(int currentTotal)
    // {

    // }
  }
}
