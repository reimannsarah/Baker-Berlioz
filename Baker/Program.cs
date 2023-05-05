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
      Console.WriteLine("Place an order? (y/n)");
      string input = Console.ReadLine();
      if (input == "y")
      {
        Console.WriteLine("What sounds good?");
        Console.WriteLine("Bread");
        Console.WriteLine("Pastry");
        string choice = Console.ReadLine().ToLower();
        if (choice == "bread")
        {
          Console.WriteLine($"Your total comes to: ${BreadOrder()}");
        }
        else if (choice == "pastry")
        {
          Console.WriteLine($"Your total comes to ${PastryOrder()}");
        }
        else
        {
          Console.WriteLine("Please choose from the listed options");
        }
      }
      // else
      // {
      //   Console.WriteLine("Goodbye!");
      // }
      // static void PlaceOrder()
      // {
      // Console.WriteLine("What sounds good?");
      // Console.WriteLine("Bread");
      // Console.WriteLine("Pastry");
      // string choice = Console.ReadLine().ToLower();
      // if(choice == "bread")
      // {
      //   Console.WriteLine($"Your total comes to: ${BreadOrder()}");
      // }
      // else if(choice == "pastry")
      // {
      // PastryOrder();
      // }
      // else
      // {
      //   Console.WriteLine("Please choose from the listed options");
      //   PlaceOrder();

      // }
      // }
      static int BreadOrder()
      {
        Console.WriteLine("How many loaves would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread newBreadOrder = new Bread(breadOrder);
        return newBreadOrder.CalculateTotal();
      }
      static int PastryOrder()
      {
        Console.WriteLine("How many pastries would you like?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry newPastryOrder = new Pastry(pastryOrder);
        return newPastryOrder.CalculateTotal();
      }
    }
  }
}